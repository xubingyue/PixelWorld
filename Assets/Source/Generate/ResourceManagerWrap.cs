﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class ResourceManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(ResourceManager), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("GetInstance", GetInstance);
		L.RegFunction("Init", Init);
		L.RegFunction("GetAssetBundleFormName", GetAssetBundleFormName);
		L.RegFunction("LoadAsset", LoadAsset);
		L.RegFunction("LoadSprite", LoadSprite);
		L.RegFunction("LoadPackSprite", LoadPackSprite);
		L.RegFunction("GetFileSize", GetFileSize);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInstance(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			ResourceManager o = ResourceManager.GetInstance();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Init(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			ResourceManager obj = (ResourceManager)ToLua.CheckObject(L, 1, typeof(ResourceManager));
			obj.Init();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAssetBundleFormName(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ResourceManager obj = (ResourceManager)ToLua.CheckObject(L, 1, typeof(ResourceManager));
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.AssetBundle o = obj.GetAssetBundleFormName(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAsset(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ResourceManager obj = (ResourceManager)ToLua.CheckObject(L, 1, typeof(ResourceManager));
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.Object o = obj.LoadAsset(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadSprite(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ResourceManager obj = (ResourceManager)ToLua.CheckObject(L, 1, typeof(ResourceManager));
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.Sprite o = obj.LoadSprite(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadPackSprite(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ResourceManager obj = (ResourceManager)ToLua.CheckObject(L, 1, typeof(ResourceManager));
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.Sprite o = obj.LoadPackSprite(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFileSize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ResourceManager obj = (ResourceManager)ToLua.CheckObject(L, 1, typeof(ResourceManager));
			string arg0 = ToLua.CheckString(L, 2);
			long o = obj.GetFileSize(arg0);
			LuaDLL.tolua_pushint64(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

