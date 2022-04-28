﻿namespace ExcelWizard.Models
{
    public class AllSheetsDefaultStyle
    {
        public SheetDirection AllSheetsDefaultDirection { get; set; } = SheetDirection.RightToLeft;

        public TextAlign AllSheetsDefaultTextAlign { get; set; } = TextAlign.Right;

        /// <summary>
        /// Default column width for the workbook.
        /// <para>All new worksheets will use this column width.</para>
        /// </summary>
        // TODO: Shouldn't it use the ColumnWidth class?
        public double AllSheetsDefaultColumnWidth { get; set; } = 20;

        /// <summary>
        /// Default row height for the workbook.
        /// <para>All new worksheets will use this row height.</para>
        /// </summary>
        public double AllSheetsDefaultRowHeight { get; set; } = 15;
    }
}