using System;


namespace Safe
{
    public class GameEngine
    {
        public  uint currentClick { get; private set; }
        public  readonly byte _fieldSize;       
        sbyte[,] field;
        Random rnd = new Random();
        
        public GameEngine(byte fieldSize)
        {           
            _fieldSize = fieldSize;
            this.field = new sbyte[fieldSize, fieldSize];                                           
            sbyte startValue =(sbyte) rnd.Next(0, 2);
                for (byte i = 0; i < fieldSize; i++)
                {
                    for (byte j = 0; j < fieldSize; j++)
                    {
                        if (startValue == 0)
                            startValue = -1;
                        field[i, j] = startValue;
                    }
                }
            SetRandomField();           
        }
        private void SetRandomField()
        {                                 
            for (int i = 0; i <= rnd.Next(15, 30); i++)
                SwitchValue((byte)rnd.Next(0, _fieldSize), (byte)rnd.Next(0, _fieldSize));
            if (IsFinished())
            {
                SetRandomField();
                return;
            }
        }
        public sbyte[,] GetField()
        {
            sbyte[,] currentField = new sbyte[_fieldSize, _fieldSize];
            for (int i = 0; i < _fieldSize; i++)
            {
                for (int j = 0; j < _fieldSize; j++)
                {
                    currentField[i, j] = field[i, j];
                }
            }
            return currentField;
        }
        public void SwitchValue(int xIndex, int yIndex)
        {
            for (int i = 0; i < _fieldSize; i++)
            {
                field[ i, yIndex] *= -1;
                field[xIndex, i] *= -1;
            }
            field[xIndex, yIndex] *= -1;
        }
        public bool IsFinished()
        {
            sbyte average = 0;
            foreach (var value in field)
                average += value;

            average /= (sbyte)field.Length;
            return Math.Abs(average) == 1 ? true : false;
        }
    }

}
