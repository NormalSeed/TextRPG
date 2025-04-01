using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scenes
{
    public class TownScene : Scene
    {
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("당신은 꿈에서 깨어난 뒤, 손에 새겨진 문양의 의미를 알기 위해 움직입니다.\n눈앞에 펼쳐진 마을 광장은 평소처럼 분주합니다.\n이제, 어떤 행동을 취할지 선택해야 합니다.");
            Console.WriteLine();
        }

        public override void Choice()
        {
            Console.WriteLine("1. 대장간으로 찾아간다.");
            Console.WriteLine("2. 장로의 집으로 찾아간다.");
            Console.WriteLine("3. 친구인 리안을 찾아간다.");
        }

        public override void Result()
        {
            Console.WriteLine();
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("당신은 일자리였던 대장간으로 찾아갔습니다. 철 두드리는 소리와 용광로의 열기가 당신을 반깁니다.");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("마을의 중심에 있는 고풍스러운 집으로 들어섭니다. 장로는 고요한 눈빛으로 당신을 바라봅니다.");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("당신은 어릴 적 친구인 리안을 찾아 나섭니다. 리안은 마을의 숲 근처에서 종종 사냥을 합니다.\n그의 얼굴을 보니, 이미 소문을 들은 듯 걱정스러운 표정입니다.");
                    break;
            }
        }

        public override void Wait()
        {
            Console.WriteLine();
            Console.WriteLine("진행하려면 아무 키나 누르세요.");
            Console.ReadKey();
        }

        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Forge");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("TalkTownElder");
                    break;
                case ConsoleKey.D3:
                    Game.ChangeScene("TalkRian");
                    break;
            }
        }
    }
}
