using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Scenes;
using TextRPG.Items.Equipables;
//using TextRPG.Items.Equipables.Armor;
//using TextRPG.Items.Equipables.Helmet;

namespace TextRPG
{
    public static class Game
    {
        // 게임에 필요한 정보들
        private static bool gameOver;

        // Scene 딕셔너리
        private static Dictionary<string, Scene> sceneDic;
        private static Scene curScene;



        private static Player player;
        public static Player Player { get { return player; } }

        // 게임에 필요한 기능 : 시작, 실행, 끝
        public static void Start()
        {
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Intro", new IntroScene());
            sceneDic.Add("Town", new TownScene());
            sceneDic.Add("Forge", new ForgeScene());

            curScene = sceneDic["Title"];


            // 플레이어 초기 스탯
            player = new Player();
            player.Job = "대장장이";
            player.HP = 20;
            player.Power = 5;
            player.Def = 5;
            player.Speed = 5;
            player.Charm = 5;
            player.Hustle = 1;
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

        public static void ChangeScene(string sceneName)
        {
            curScene = sceneDic[sceneName];
        }

        public static void EquipItem(Player player, IEquipable item)
        {
            // 장착되어있던 장비를 아이템 인벤토리에 넣어야 한다.
            // TODO : 아이템 인벤토리 구현
            item.Equip(player);
        }

        public static  void UnequipItem(Player player, IEquipable item)
        {
            item.Unequip(player);
        }

        public static void End()
        {

        }
    }
}
