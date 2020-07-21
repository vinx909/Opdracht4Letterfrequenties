using System;
using System.Collections.Generic;
using System.IO;

namespace Opdracht4Letterfrequenties
{
    internal class CharacterCounter
    {
        private const string fileNotFoundText = "file not found";
        private const string breakBetweenInstances = "\t";//"\r\n";
        private static readonly char[] orderArray = {
            '1',
            '2',
            '3',
            '4',
            '5',
            '6',
            '7',
            '8',
            '9',
            '0',
            'A',
            'a',
            'B',
            'b',
            'C',
            'c',
            'D',
            'd',
            'E',
            'e',
            'F',
            'f',
            'G',
            'g',
            'H',
            'h',
            'I',
            'i',
            'J',
            'j',
            'K',
            'k',
            'L',
            'l',
            'M',
            'm',
            'N',
            'n',
            'O',
            'o',
            'P',
            'p',
            'Q',
            'q',
            'R',
            'r',
            'S',
            's',
            'T',
            't',
            'U',
            'u',
            'V',
            'v',
            'W',
            'w',
            'X',
            'x',
            'Y',
            'y',
            'Z',
            'z'
        };

        internal static string GetCharactersString(string filePath)
        {
            if (File.Exists(filePath))
            {
                string text = File.ReadAllText(filePath);
                char[] characters = text.ToCharArray();
                List<CharacterTicker> characterTickers = new List<CharacterTicker>();
                foreach(char character in characters)
                {
                    bool exists = false;
                    foreach(CharacterTicker ticker in characterTickers)
                    {
                        if (ticker.IsCharacter(character))
                        {
                            ticker.IncreaseCount();
                            exists = true;
                        }
                    }
                    if (exists==false)
                    {
                        characterTickers.Add(new CharacterTicker(character));
                    }
                }
                OrderCharacterList(characterTickers);
                string result = "";
                foreach (CharacterTicker ticker in characterTickers)
                {
                    result += ticker.GetString() + breakBetweenInstances;
                }
                return result;
                }
            else
            {
                return fileNotFoundText;
            }
        }

        private static void OrderCharacterList(List<CharacterTicker> list)
        {
            int index = 0;
            foreach(char character in orderArray)
            {
                for(int i = 0; i < list.Count; i++)
                {
                    if (list[i].IsCharacter(character))
                    {
                        CharacterTicker toMove = list[index];
                        list[index] = list[i];
                        list[i] = toMove;
                        index++;
                        break;
                    }
                }
            }
        }
    }

    internal class CharacterTicker
    {
        char character;
        int count;

        internal CharacterTicker(char character)
        {
            this.character = character;
            count = 1;
        }
        internal void IncreaseCount()
        {
            count++;
        }
        internal bool IsCharacter(char character)
        {
            return this.character == character;
        }
        internal string GetString()
        {
            return "\""+character + "\": " + count;
        }
    }
}