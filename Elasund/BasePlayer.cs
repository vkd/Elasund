using System.Drawing;

namespace Elasund
{
	class BasePlayer
	{
		//очки игрока
		public int _score;
		//деньги
		public int _money;
		//карты влияния
		public int[] _votes;
		// Куски стен игрока
		public int _wall = 1;
		// Цвет игрока
      //public ColorPlayer _color;


      /// <summary>
      /// Конструктор определяет цвет игрока и начальную карту голоса
      /// </summary>
      /// <param name="colorPlayer">Цвет игрока</param>
      /// <param name="voteNumber">Стартовая карта голоса</param>
      public BasePlayer(Color parColor, int parVote)
      {
         //_color = parColor;
         _score = 10;
         _money = 3;
         _votes = new int[3];
         _votes[parVote] = 1;

         //массив заявок
      }

		/// <summary>
		/// Изменить количество очков
		/// </summary>
		/// <param name="value">На сколько изменить</param>
		/// <returns>Истина, если кончились очки и игрок выйграл</returns>
		public bool ChangeScoreBy(int value)
		{
			_score += value;
			return _score == 0 ? true : false;
		}
	}
}
