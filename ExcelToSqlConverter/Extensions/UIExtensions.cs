namespace ExcelToSqlConverter.Extensions
{
    public static class UIExtensions
    {
        public static void FitFontSize(this Control control, float maxFontSize)
        {
            if (!string.IsNullOrWhiteSpace(control.Text))
            {
                control.Font = control.Font.FitToRect(control.Text, control.Width, control.Height, maxFontSize);
            }
        }

        public static Font FitToRect(this Font font, string text, int rectWidth, int rectHeight, float maxFontSize)
        {
            font = new(font.FontFamily, maxFontSize, font.Style);
            var linesInRect = (rectHeight / font.Height) + 1;
            while (rectWidth * linesInRect < TextRenderer.MeasureText(text, font).Width)
            {
                font = new(font.FontFamily, font.Size - 0.5f, font.Style);
                linesInRect = (rectHeight / font.Height) + 1;
            }

            return font;
        }
    }
}
