namespace ExcelToSqlConverter.Helpers
{
    public static class CollectionOperations
    {
        /// <summary>
        /// Декартово произведение коллекций.
        /// </summary>
        /// <typeparam name="T">Тип коллекций.</typeparam>
        /// <param name="collections">Коллекции.</param>
        /// <returns>Возвращает (лениво) список массивов, содержащих все сочетания элементов коллекций.<br/>
        /// Например: ["a", "b", "c"] x ["1", "2"] -> ["a", "1"], ["a", "2"], ["b", "1"], ...</returns>
        public static IEnumerable<T[]> CrossJoin<T>(params IEnumerable<T>[] collections)
        {
            var enumers = collections.Select(x => x.GetEnumerator()).ToArray();
            var moved = enumers.All(e => e.MoveNext());

            if (moved)
                yield return enumers.Select(x => x.Current).ToArray();
            else
                yield break;

            while (moved)
            {
                moved = false;
                foreach (var e in enumers)
                {
                    if (e.MoveNext())
                    {
                        moved = true;
                        yield return enumers.Select(x => x.Current).ToArray();
                        break;
                    }

                    e.Reset();
                    e.MoveNext();
                }
            }
        }
    }
}
