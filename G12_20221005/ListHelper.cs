namespace G12_20221005
{
	static class ListHelper
	{
		private static void ValidateParameters<T>(IEnumerable<T> list, Func<T, bool> predicate)
		{
			if (list == null) throw new ArgumentNullException(nameof(list));
			if (predicate == null) throw new ArgumentNullException(nameof(predicate));
		}

		/// <summary>
		/// ფუნქციამ უნდა გაფილტროს მიღებული სია გადმოცემული პრედიკატის მიხედვით
		/// და დააბრუნოს მხოლოდ ისეთი ელემენტებისგან შემდგარი სია, რომლებიც აკმაყოფილებს
		/// პრედიკატში გადმოცემულ პირობას.
		/// </summary>
		public static IEnumerable<T> Where<T>(IEnumerable<T> list, Func<T, bool> predicate)
		{
			ValidateParameters(list, predicate);


			ICollection<T> result = new List<T>();

			foreach (T item in list)
			{
                if (predicate(item))
					result.Add(item);

			//		continue;
            }

			return result;
		}

		/// <summary>
		/// ფუნქციამ უნდა შეამოწმოს თუ გადმოცემულ სიაში, რომელიმე ელემენტი აკმაყოფილებს
		/// პრედიკატში გადმოცემულ პირობას და დააბრუნოს True წინააღმდეგ შემთხვევაში False.
		/// </summary>
		public static bool Any<T>(IEnumerable<T> list, Func<T, bool> predicate)
		{
			ValidateParameters(list, predicate);

			foreach (T item in list)
			{
                if (predicate(item))
					return true;
			}

			return false;
		}

		/// <summary>
		/// ფუნქციამ უნდა შეამოწმოს თუ გადმოცემულ სიაში, ყველა ელემენტი აკმაყოფილებს
		/// პრედიკატში გადმოცემულ პირობას და დააბრუნოს True წინააღმდეგ შემთხვევაში False.
		/// </summary>
		public static bool All<T>(IEnumerable<T> list, Func<T, bool> predicate)
		{
			ValidateParameters(list, predicate);
			
            foreach (T item in list)
            {
				if (!predicate(item))
					return false;
				
            }

            return true;
        }
	}

}
