﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SceneIDWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(SceneID));
		L.RegVar("Login", get_Login, null);
		L.RegVar("Main", get_Main, null);
		L.RegVar("Loading", get_Loading, null);
		L.RegVar("Battle", get_Battle, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Login(IntPtr L)
	{
		ToLua.Push(L, SceneID.Login);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Main(IntPtr L)
	{
		ToLua.Push(L, SceneID.Main);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Loading(IntPtr L)
	{
		ToLua.Push(L, SceneID.Loading);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Battle(IntPtr L)
	{
		ToLua.Push(L, SceneID.Battle);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		SceneID o = (SceneID)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

