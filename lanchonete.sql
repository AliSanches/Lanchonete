-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 07-Maio-2024 às 22:51
-- Versão do servidor: 10.1.31-MariaDB
-- PHP Version: 7.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `lanchonete`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `id_cliente` int(11) NOT NULL,
  `nome` varchar(70) NOT NULL,
  `cpf` varchar(20) NOT NULL,
  `telefone` varchar(30) DEFAULT NULL,
  `celular` varchar(30) NOT NULL,
  `estado` varchar(20) NOT NULL,
  `cidade` varchar(45) NOT NULL,
  `bairro` varchar(50) NOT NULL,
  `rua` varchar(40) NOT NULL,
  `numero` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`id_cliente`, `nome`, `cpf`, `telefone`, `celular`, `estado`, `cidade`, `bairro`, `rua`, `numero`) VALUES
(1, 'Padrão', '000,000,000-00', '(00) 0000-0000', '(00) 0 0000-0000', 'Neutro', 'Padrão', 'Padrão', 'Padrão', 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `ingrediente`
--

CREATE TABLE `ingrediente` (
  `id_ingrediente` int(11) NOT NULL,
  `nome_ingrediente` varchar(150) NOT NULL,
  `quantidade_estoque` int(11) NOT NULL,
  `preco_ingrediente` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `ingrediente`
--

INSERT INTO `ingrediente` (`id_ingrediente`, `nome_ingrediente`, `quantidade_estoque`, `preco_ingrediente`) VALUES
(1, 'Presunto', 150, '15.00'),
(2, 'Queijo', 150, '15.00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `itens_venda`
--

CREATE TABLE `itens_venda` (
  `id_itens_venda` int(11) NOT NULL,
  `venda_id` int(11) DEFAULT NULL,
  `id_ingrediente` int(11) NOT NULL,
  `quantidade_utilizada` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `itens_venda`
--

INSERT INTO `itens_venda` (`id_itens_venda`, `venda_id`, `id_ingrediente`, `quantidade_utilizada`) VALUES
(1, 3, 1, 50),
(2, 3, 2, 50);

-- --------------------------------------------------------

--
-- Estrutura da tabela `itens_venda_lanche`
--

CREATE TABLE `itens_venda_lanche` (
  `id_itens_venda` int(11) NOT NULL,
  `venda_id` int(11) DEFAULT NULL,
  `id_lanche` int(11) NOT NULL,
  `quantidade_utilizada` int(11) NOT NULL,
  `subtotal` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `itens_venda_lanche`
--

INSERT INTO `itens_venda_lanche` (`id_itens_venda`, `venda_id`, `id_lanche`, `quantidade_utilizada`, `subtotal`) VALUES
(1, 3, 1, 2, '45.00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `lanche`
--

CREATE TABLE `lanche` (
  `id_lanche` int(11) NOT NULL,
  `nome_lanche` varchar(150) NOT NULL,
  `descricao_lanche` varchar(150) NOT NULL,
  `preco_lanche` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `lanche`
--

INSERT INTO `lanche` (`id_lanche`, `nome_lanche`, `descricao_lanche`, `preco_lanche`) VALUES
(1, 'Misto Quente', 'Presunto, Queijo', '22.50');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `id_usuario` int(11) NOT NULL,
  `nome_completo` varchar(70) NOT NULL,
  `cpf` varchar(20) NOT NULL,
  `email` varchar(70) NOT NULL,
  `nome_login` varchar(40) NOT NULL,
  `senha` varchar(20) NOT NULL,
  `nivel_acesso` varchar(20) NOT NULL,
  `telefone` varchar(30) DEFAULT NULL,
  `celular` varchar(30) NOT NULL,
  `estado` varchar(20) NOT NULL,
  `cidade` varchar(45) NOT NULL,
  `bairro` varchar(50) NOT NULL,
  `rua` varchar(40) NOT NULL,
  `numero` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `venda`
--

CREATE TABLE `venda` (
  `id_venda` int(11) NOT NULL,
  `data_venda` datetime NOT NULL,
  `id_cliente` int(11) DEFAULT NULL,
  `id_lanche` int(11) DEFAULT NULL,
  `total_venda` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `venda`
--

INSERT INTO `venda` (`id_venda`, `data_venda`, `id_cliente`, `id_lanche`, `total_venda`) VALUES
(1, '2024-05-07 00:00:00', 1, 1, '45.00'),
(2, '2024-05-07 00:00:00', 1, 1, '45.00'),
(3, '2024-05-07 00:00:00', 1, 1, '45.00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id_cliente`),
  ADD UNIQUE KEY `cpf` (`cpf`);

--
-- Indexes for table `ingrediente`
--
ALTER TABLE `ingrediente`
  ADD PRIMARY KEY (`id_ingrediente`),
  ADD UNIQUE KEY `nome_ingrediente` (`nome_ingrediente`);

--
-- Indexes for table `itens_venda`
--
ALTER TABLE `itens_venda`
  ADD PRIMARY KEY (`id_itens_venda`),
  ADD KEY `id_ingrediente` (`id_ingrediente`),
  ADD KEY `venda_id` (`venda_id`);

--
-- Indexes for table `itens_venda_lanche`
--
ALTER TABLE `itens_venda_lanche`
  ADD PRIMARY KEY (`id_itens_venda`),
  ADD KEY `venda_id` (`venda_id`),
  ADD KEY `id_lanche` (`id_lanche`);

--
-- Indexes for table `lanche`
--
ALTER TABLE `lanche`
  ADD PRIMARY KEY (`id_lanche`),
  ADD UNIQUE KEY `nome_lanche` (`nome_lanche`);

--
-- Indexes for table `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id_usuario`),
  ADD UNIQUE KEY `cpf` (`cpf`);

--
-- Indexes for table `venda`
--
ALTER TABLE `venda`
  ADD PRIMARY KEY (`id_venda`),
  ADD KEY `id_cliente` (`id_cliente`),
  ADD KEY `id_lanche` (`id_lanche`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `itens_venda`
--
ALTER TABLE `itens_venda`
  MODIFY `id_itens_venda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `itens_venda_lanche`
--
ALTER TABLE `itens_venda_lanche`
  MODIFY `id_itens_venda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `lanche`
--
ALTER TABLE `lanche`
  MODIFY `id_lanche` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `venda`
--
ALTER TABLE `venda`
  MODIFY `id_venda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `itens_venda`
--
ALTER TABLE `itens_venda`
  ADD CONSTRAINT `itens_venda_ibfk_1` FOREIGN KEY (`id_ingrediente`) REFERENCES `ingrediente` (`id_ingrediente`),
  ADD CONSTRAINT `itens_venda_ibfk_2` FOREIGN KEY (`venda_id`) REFERENCES `venda` (`id_venda`);

--
-- Limitadores para a tabela `itens_venda_lanche`
--
ALTER TABLE `itens_venda_lanche`
  ADD CONSTRAINT `itens_venda_lanche_ibfk_1` FOREIGN KEY (`venda_id`) REFERENCES `venda` (`id_venda`),
  ADD CONSTRAINT `itens_venda_lanche_ibfk_2` FOREIGN KEY (`id_lanche`) REFERENCES `lanche` (`id_lanche`);

--
-- Limitadores para a tabela `venda`
--
ALTER TABLE `venda`
  ADD CONSTRAINT `venda_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`),
  ADD CONSTRAINT `venda_ibfk_2` FOREIGN KEY (`id_lanche`) REFERENCES `lanche` (`id_lanche`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
