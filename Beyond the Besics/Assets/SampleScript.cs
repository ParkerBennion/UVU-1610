using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BeyondTheBasics.Gameplay
{
	public class SampleScript : MonoBehaviour
	{

		#region Variable Declarations

		public int numberToDisplay;
		private int numberToMultiplyBy;

		#endregion

		#region Private Methods

		private void Start()
		{
			SayHelloWorld();
		}

		private void SayHelloWorld()
		{
			var randomNumber = Random.Range(0, numberToDisplay);
			var displayText = "hello world";
			for (var i = 0; i < randomNumber; i++)
			{
				Debug.Log(displayText);
			}
		}

		private void MultiplyNumber(int numberToMultiply)
		{
			int product = numberToMultiply * numberToMultiplyBy;

			Debug.Log(product);
		}

		private void AnonymousTypeExample()
		{
			var enemy = new { name = "Monster", hitPoints = 100 };
		}

		#endregion
	}
}
