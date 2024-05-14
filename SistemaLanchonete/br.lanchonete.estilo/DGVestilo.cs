﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEdit
{
    public class DGVDestilo
    {
        public static void Formato(DataGridView pData, int color)
        {
            //Font Linhas
            pData.RowsDefaultCellStyle.Font = new Font("Montserrat", 10f, FontStyle.Regular);
            //Font Colunas
            pData.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 12f, FontStyle.Bold);
            //Ancho Colunas
            pData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Alto Linhas
            pData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //Não acrecenta linhas extras
            pData.AutoGenerateColumns = false;
            //Bordas
            pData.BorderStyle = BorderStyle.None;
            pData.EnableHeadersVisualStyles = false;
            pData.RowHeadersVisible = false;
            pData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //Cor nas Coluans
            pData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            switch (color)
            {
                case 1:
                    //Coluna
                    pData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 136, 136);
                    //Linha
                    pData.RowsDefaultCellStyle.BackColor = Color.FromArgb(94, 152, 208);
                    pData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(143, 191, 231);
                    pData.RowsDefaultCellStyle.Padding = new Padding(0, 5, 0, 5);
                    //Linha Alternativa
                    pData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(220, 230, 241);
                    pData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(119, 174, 223);
                    pData.AlternatingRowsDefaultCellStyle.Padding = new Padding(20, 5, 20, 5);
                    break;
                case 2:
                    //Coluna
                    pData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 0);
                    //linha
                    pData.RowsDefaultCellStyle.BackColor = Color.FromArgb(166, 166, 166);
                    pData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(107, 149, 183);
                    //Linha Alternativa
                    pData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(217, 217, 217);
                    pData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(141, 183, 216);
                    break;
                case 3:
                    //Coluna
                    pData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(192, 80, 77);
                    //Linha
                    pData.RowsDefaultCellStyle.BackColor = Color.FromArgb(230, 184, 183);
                    pData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(149, 161, 194);
                    //Linha Alternativa
                    pData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 220, 219);
                    pData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(157, 185, 217);
                    break;
                case 4:
                    //Coluna
                    pData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(155, 187, 89);
                    //Linha
                    pData.RowsDefaultCellStyle.BackColor = Color.FromArgb(216, 228, 188);
                    pData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(140, 190, 197);
                    //Linha Alternativa
                    pData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 241, 222);
                    pData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(152, 198, 219);
                    break;
                case 5:
                    //Coluna
                    pData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 100, 162);
                    //Linha
                    pData.RowsDefaultCellStyle.BackColor = Color.FromArgb(204, 192, 218);
                    pData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(132, 166, 216);
                    //Linha Alternativa
                    pData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(228, 223, 236);
                    pData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(148, 186, 228);
                    break;
                case 6:
                    //Coluna
                    pData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(75, 172, 198);
                    //Linha
                    pData.RowsDefaultCellStyle.BackColor = Color.FromArgb(183, 222, 232);
                    pData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(118, 186, 226);
                    //Linha Alternativa
                    pData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(218, 238, 243);
                    pData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(141, 196, 233);
                    break;
                case 7:
                    //Coluna
                    pData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(247, 150, 70);
                    //Linha
                    pData.RowsDefaultCellStyle.BackColor = Color.FromArgb(252, 213, 180);
                    pData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(163, 180, 192);
                    //Linha Alternativa
                    pData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(253, 233, 217);
                    pData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(164, 193, 216);
                    break;
            }
        }
    }
}