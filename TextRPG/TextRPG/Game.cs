using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Scenes;

namespace TextRPG
{
    public static class Game
    {
        // 게임에 필요한 정보
        private static bool gameOver;
        private static Dictionary<string, Scene> sceneDic;
        private static Scene curScene;

        // 게임에 필요한 기능
        // 시작, 실행, 끝
        public static void Start()
        {
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            curScene = sceneDic["Title"];
        }

        public static void Run()
        {
            while (gameOver == false)
            {
                Console.Clear();

                curScene.Render();
                curScene.Choice();
                curScene.Input();
                curScene.Result();
                curScene.Wait();
                curScene.Next();
            }
        }

        public static void End()
        {

        }
    }
}
