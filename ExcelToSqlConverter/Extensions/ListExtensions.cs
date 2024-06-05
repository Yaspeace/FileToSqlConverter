namespace ExcelToSqlConverter.Extensions
{
    public static class ListExtensions
    {
        public static void MoveForward<T>(this List<T> list, T item)
        {
            var idx = list.IndexOf(item);
            if (idx == -1) return;

            list.RemoveAt(idx--);
            list.Insert(Math.Max(idx, 0), item);
        }

        public static void MoveBackward<T>(this List<T> list, T item)
        {
            var idx = list.IndexOf(item);
            if (idx == -1) return;

            list.RemoveAt(idx++);
            list.Insert(Math.Min(idx, list.Count), item);
        }
    }
}
