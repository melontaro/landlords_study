﻿using System;
using System.Collections.Generic;

namespace ETModel
{

    public static partial class LandUIType
    {
        public const string LandLogin = "LandLogin";
        public const string LandLobby = "LandLobby";
        public const string SetUserInfo = "SetUserInfo";
        public const string LandRoom = "LandRoom";
        public const string LandInteraction = "LandInteraction";
        public const string LandEnd = "LandEnd";

        


    }

    public static partial class UIEventType
    {
        public const string LandInitSceneStart = "LandInitSceneStart";
        public const string LandLoginFinish = "LandLoginFinish";
        public const string LandInitLobby = "LandInitLobby";
        public const string LandInitSetUserInfo = "LandInitSetUserInfo";
        public const string LandSetUserInfoFinish = "LandSetUserInfoFinish";

    }

    [Event(UIEventType.LandInitSceneStart)]
    public class InitSceneStart_CreateLandLogin : AEvent
    {
        public override void Run()
        {
            Game.Scene.GetComponent<UIComponent>().Create(LandUIType.LandLogin);
        }
    }

    //移除登录界面事件
    [Event(UIEventType.LandLoginFinish)]
    public class LandLoginFinish : AEvent
    {
        public override void Run()
        {
            Game.Scene.GetComponent<UIComponent>().Remove(LandUIType.LandLogin);
        }
    }

    //初始化大厅界面事件方法
    [Event(UIEventType.LandInitLobby)]
    public class LandInitLobby_CreateLandLobby : AEvent
    {
        public override void Run()
        {
            Game.Scene.GetComponent<UIComponent>().Create(LandUIType.LandLobby);
        }
    }

    //初始设置用户信息事件方法
    [Event(UIEventType.LandInitSetUserInfo)]
    public class LandInitUserInfo_CreateSetUserInfo : AEvent
    {
        public override void Run()
        {
            Game.Scene.GetComponent<UIComponent>().Create(LandUIType.SetUserInfo);
        }
    }

    //登录完成移除登录界面事件方法
    [Event(UIEventType.LandSetUserInfoFinish)]
    public class LandSetUserInfoFinish : AEvent
    {
        public override void Run()
        {
            Game.Scene.GetComponent<UIComponent>().Remove(LandUIType.SetUserInfo);

        }
    }

}