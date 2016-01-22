using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MGB_one
{
    public class MGBRewardArray
    {
        private byte[] _rewards;

        public byte[] Rewards
        {
            get { return _rewards; }
            set { _rewards = ValidateValues(value); }
        }
        public int Length { get { return _rewards.Length; } }

        public MGBRewardArray()
        {
            _rewards = new byte[Settings.MGB_MAX_GAME_LVL];
            ResetAll();
        }

        public bool ResetAt(int index)
        {
            if (index < 0 || index > _rewards.Length)
                return false;
            else
            {
                _rewards[index] = 0;
                return true;
            }
        }

        public void ResetAll()
        {
            for (int i = 0; i < _rewards.Length; i++)
            {
                _rewards[i] = 0;
            }
        }

        public bool SetValueAt(int index, byte value)
        {
            if (index < 0 || index > _rewards.Length)
                return false;
            else
            {
                if (value > Settings.MGB_MAX_GAME_POINTS)
                    value = Settings.MGB_MAX_GAME_POINTS;
                _rewards[index] = value;
                return true;
            }
        }
        private byte[] ValidateValues(byte[] array)
        {
            for (int i=0;i< array.Length; i++)
            {
                if (array[i] > Settings.MGB_MAX_GAME_POINTS)
                    array[i] = Settings.MGB_MAX_GAME_POINTS;
            }
            return array;
        }
    }
}
