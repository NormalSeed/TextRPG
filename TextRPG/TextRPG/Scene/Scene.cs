using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Scene
{
    public abstract class Scene
    {
        protected ConsoleKey input;
        // <summary>
        // 씬의 상황 작성
        // </summary>
        public abstract void Render();

        // <summary>
        // 씬의 선택지 제시
        // </summary>
        public abstract void Choice();

        // <summary>
        // 선택지 입력
        // </summary>
        public void Input(ConsoleKey input)
        {
            input = Console.ReadKey(true).Key;
        }

        // <summary>
        // 선택지에 따른 결과 출력
        // </summary>
        public abstract void Result();

        // <summary>
        // 다음 씬으로 가기 전 대기
        // </summary>
        public abstract void Wait();

        // <summary>
        // 다음 씬으로 전환
        // </summary>
        public abstract void Next();
    }
}
