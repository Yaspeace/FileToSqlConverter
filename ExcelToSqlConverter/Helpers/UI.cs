using ExcelToSqlConverter.Enums;

namespace ExcelToSqlConverter.Helpers
{
    public static class UI
    {
        public static DialogResult ShowError(string message)
            => MessageBox.Show(message, UIStrings.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
