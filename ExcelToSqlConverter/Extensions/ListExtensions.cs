namespace ExcelToSqlConverter.Extensions
{
    public static class ListExtensions
    {
        public static void MoveForward<T>(this List<T> list, T item)
        {
            var idx = list.IndexOf(item);
            if (idx >= 0) list.MoveToIndex(Math.Max(idx - 1, 0), item);
        }

        public static void MoveBackward<T>(this List<T> list, T item)
        {
            var idx = list.IndexOf(item);
            if (idx >= 0) list.MoveToIndex(Math.Min(idx + 1, list.Count - 1), item);
        }

        public static void MoveToIndex<T>(this List<T> list, int index, T item)
        {
            list.Remove(item);
            list.Insert(index, item);
        }

        public static void MoveToTop<T>(this List<T> list, T item)
            => list.MoveToIndex(0, item);

        public static void MoveToBack<T>(this List<T> list, T item)
        {
            list.Remove(item);
            list.Add(item);
        }
    }
}
