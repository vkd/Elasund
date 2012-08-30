using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dice
{
	/// <summary>
	/// Класс игральных костей, случайно перебирает все возможные варианты суммы кубиков
	/// </summary>
	public class SumDice
	{
		private List<int> FutureResults;
		Random random = new Random();

		private int dimension;
		private int quantity;
		private int result;

		/// <summary>
		/// Получить последний результат
		/// </summary>
		/// <returns>Последний результат</returns>
		public int GetResult()
		{
			return result;
		}

		/// <summary>
		/// Конструктор суммы очков выпавших на кубиках
		/// </summary>
		/// <param name="quantity">Количество кубиков</param>
		/// <param name="dimension">Разрядность кубиков</param>
		public SumDice(int q, int dim)
		{
			quantity = q;
			dimension = dim;
			FutureResults = new List<int>();
		}

		/// <summary>
		/// Сброс прошлых результатов и добавление
		/// всех возможных результатов суммы при броске 
		/// quantity-количества игральных кубиков с 
		/// dimension-количеством граней
		/// Для обеспечения точной вероятности выпадения суммы точек на кубиках
		/// </summary>
		public void Refresh()
		{
			//очистка предыдущих результатов
			FutureResults.Clear();

			//это наши кубики - и мы будем полным перебором
			//искать все суммы
			int[] number = new int[quantity];

			//начальное положение кубиков - все еденицы
			for (int i = 0; i < quantity; i++)
				number[i] = 1;

			int sum = 0;

			//пока количество точек на последнем не больше возможного
			while(number[quantity-1] <= dimension) 
			{
				sum = 0;
				//находим сумму
				for (int i = 0; i < quantity; i++)
					sum += number[i];

				FutureResults.Add(sum);

				//увеличиваем значение на младшем кубике
				number[0]++;

				//проверяем на правильность все кубики
				for (int i = 0; i < quantity - 1; i++)
				{
					//если на кубике точек стало больше допустимого
					if (number[i] > dimension)
					{
						//прибавляем к старшему еденицу
						number[i + 1]++;
						number[i] -= dimension;
					}
				}
			}
		}

		/// <summary>
		/// Скинуть кости и получить сумму точек
		/// </summary>
		public int GetNextResult()
		{
			if (FutureResults.Count == 0)
				Refresh();
			int r = random.Next(FutureResults.Count);
			result = FutureResults[r];
			FutureResults.RemoveAt(r);
			return result;
		}
	}
}
