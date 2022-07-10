using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;

namespace javassist.util;

[NonNestedInnerClass("com.sun.jdi.connect.Connector$Argument")]
public class HotSwapper : java.lang.Object
{
	[SpecialName]
	[EnclosingMethod(null, "startDaemon", "()V")]
	internal class _1 : Thread
	{
		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal HotSwapper this_00240;

		private static MH<object, object> ___003C_003EinvokeCache;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		private static MH<object, bool> ___003C_003EinvokeCache;

		private static MH<object, object> ___003C_003EinvokeCache;

		private static Class m____003C_003Eclass;

		private static MHV<object> ___003C_003EinvokeCache;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 108, 111, 109 })]
		private void errorMsg(System.Exception P_0)
		{
			java.lang.System.err.print("Exception in thread \"HotSwap\" ");
			Throwable.instancehelper_printStackTrace(P_0, java.lang.System.err);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(220)]
		internal _1(HotSwapper P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 114, 130, 108, 103, 104, 103, 116, 107, 130,
			210, 2, 98, 168, 99, 218, 2, 98, 136
		})]
		public override void run()
		{
			object obj = null;
			System.Exception ex;
			try
			{
				obj = this_00240.waitEvent();
				object obj2 = _1.___003C_003EMHC(obj);
				while (_1.___003C_003EMHC(obj2))
				{
					object obj3 = _1.___003C_003EMHC(obj2);
					if (obj3 != null && ByteCodeHelper.DynamicInstanceOf(obj3, _1.___003C_003Eclass()))
					{
						this_00240.hotswap();
						break;
					}
				}
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_0054;
			}
			goto IL_0063;
			IL_0054:
			System.Exception ex2 = ex;
			errorMsg(ex2);
			goto IL_0063;
			IL_0063:
			System.Exception ex3;
			try
			{
				if (obj != null)
				{
					_1.___003C_003EMHC(obj);
				}
				return;
			}
			catch (System.Exception x2)
			{
				ex3 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
			}
			ex2 = ex3;
			errorMsg(ex2);
		}

		static object ___003C_003EMHC(object P_0)
		{
			if (_1.___003C_003EinvokeCache == null)
			{
				_1.___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MH<object, object>>(9, "com.sun.jdi.event.EventSet", "eventIterator", "()Lcom.sun.jdi.event.EventIterator;", _1.___003CGetCallerID_003E());
			}
			return _1.___003C_003EinvokeCache(P_0);
		}

		static CallerID ___003CGetCallerID_003E()
		{
			if (___003CcallerID_003E == null)
			{
				___003CcallerID_003E = new ___003CCallerID_003E();
			}
			return ___003CcallerID_003E;
		}

		static bool ___003C_003EMHC(object P_0)
		{
			if (_1.___003C_003EinvokeCache == null)
			{
				_1.___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MH<object, bool>>(9, "com.sun.jdi.event.EventIterator", "hasNext", "()Z", _1.___003CGetCallerID_003E());
			}
			return _1.___003C_003EinvokeCache(P_0);
		}

		static object ___003C_003EMHC(object P_0)
		{
			if (_1.___003C_003EinvokeCache == null)
			{
				_1.___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MH<object, object>>(9, "com.sun.jdi.event.EventIterator", "nextEvent", "()Lcom.sun.jdi.event.Event;", _1.___003CGetCallerID_003E());
			}
			return _1.___003C_003EinvokeCache(P_0);
		}

		static Class ___003C_003Eclass()
		{
			if (m____003C_003Eclass == null)
			{
				m____003C_003Eclass = ByteCodeHelper.DynamicClassLiteral("com.sun.jdi.event.MethodEntryEvent", _1.___003CGetCallerID_003E());
			}
			return m____003C_003Eclass;
		}

		static void ___003C_003EMHC(object P_0)
		{
			if (___003C_003EinvokeCache == null)
			{
				___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MHV<object>>(9, "com.sun.jdi.event.EventSet", "resume", "()V", _1.___003CGetCallerID_003E());
			}
			___003C_003EinvokeCache(P_0);
		}

		[HideFromJava]
		static _1()
		{
			Thread.___003Cclinit_003E();
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	private object jvm;

	private object request;

	[Signature("Ljava/util/Map<Lcom/sun/jdi/ReferenceType;[B>;")]
	private Map newClassFiles;

	private Trigger trigger;

	private const string HOST_NAME = "localhost";

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static string TRIGGER_NAME;

	private static Class m____003C_003Eclass;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	private static MH<object, Map> ___003C_003EinvokeCache;

	private static Class m____003C_003Eclass;

	private static MHV<object, string> ___003C_003EinvokeCache;

	private static MH<object, Map, object> ___003C_003EinvokeCache;

	private static MH<object, object> ___003C_003EinvokeCache;

	private static MH<object> ___003C_003EinvokeCache;

	private static MH<object, List> ___003C_003EinvokeCache;

	private static Class m____003C_003Eclass;

	private static MH<object, string> ___003C_003EinvokeCache;

	private static Class m____003C_003Eclass;

	private static MH<object, object> ___003C_003EinvokeCache;

	private static MHV<object, string> ___003C_003EinvokeCache;

	private static MHV<object, int> ___003C_003EinvokeCache;

	private static Class m____003C_003Eclass;

	private static MHV<object, object> ___003C_003EinvokeCache;

	private static MH<object, string, List> ___003C_003EinvokeCache;

	private static Class m____003C_003Eclass;

	private static MHV<object> ___003C_003EinvokeCache;

	private static MHV<object> ___003C_003EinvokeCache;

	private static MH<object, object> ___003C_003EinvokeCache;

	private static MH<object, object> ___003C_003EinvokeCache;

	private static MHV<object, Map> ___003C_003EinvokeCache;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(new byte[] { 160, 141, 108 })]
	internal virtual object waitEvent()
	{
		object obj = HotSwapper.___003C_003EMHC(jvm);
		return HotSwapper.___003C_003EMHC(obj);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 146, 103, 110, 103 })]
	internal virtual void hotswap()
	{
		Map map = newClassFiles;
		object obj = jvm;
		Map map2 = map;
		HotSwapper.___003C_003EMHC(obj, map2);
		newClassFiles = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "com.sun.jdi.connect.IllegalConnectorArgumentsException" })]
	[LineNumberTable(new byte[]
	{
		71, 104, 103, 103, 103, 107, 102, 147, 103, 127,
		5, 127, 1, 113, 109, 116
	})]
	public HotSwapper(string port)
	{
		jvm = null;
		request = null;
		newClassFiles = null;
		trigger = new Trigger();
		object obj = findConnector("com.sun.jdi.SocketAttach");
		if (obj != null)
		{
			obj = ByteCodeHelper.DynamicCast(obj, HotSwapper.___003C_003Eclass());
		}
		object obj2 = obj;
		Map map = HotSwapper.___003C_003EMHC(obj2);
		object obj3 = map.get("hostname");
		if (obj3 != null)
		{
			obj3 = ByteCodeHelper.DynamicCast(obj3, HotSwapper.___003C_003Eclass());
		}
		string text = "localhost";
		HotSwapper.___003C_003EMHC(obj3, text);
		object obj4 = map.get("port");
		if (obj4 != null)
		{
			obj4 = ByteCodeHelper.DynamicCast(obj4, HotSwapper.___003C_003Eclass());
		}
		text = port;
		HotSwapper.___003C_003EMHC(obj4, text);
		Map map2 = map;
		jvm = HotSwapper.___003C_003EMHC(obj2, map2);
		object obj5 = HotSwapper.___003C_003EMHC(jvm);
		text = TRIGGER_NAME;
		request = methodEntryRequests(obj5, text);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 88, 139, 127, 4, 110, 34, 162 })]
	private object findConnector(string P_0)
	{
		List list = HotSwapper.___003C_003EMHC(HotSwapper.___003C_003EMHC());
		Iterator iterator = list.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			if (obj != null)
			{
				obj = ByteCodeHelper.DynamicCast(obj, HotSwapper.___003C_003Eclass());
			}
			object obj2 = obj;
			if (java.lang.String.instancehelper_equals(HotSwapper.___003C_003EMHC(obj2), P_0))
			{
				return obj2;
			}
		}
		string message = new StringBuilder().append("Not found: ").append(P_0).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IOException(message);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 105, 143, 103, 105, 105 })]
	private static object methodEntryRequests(object P_0, string P_1)
	{
		object obj = P_0;
		if (obj != null)
		{
			obj = ByteCodeHelper.DynamicCast(obj, HotSwapper.___003C_003Eclass());
		}
		object obj2 = HotSwapper.___003C_003EMHC(P_0);
		HotSwapper.___003C_003EMHC(obj2, P_1);
		int num = 1;
		HotSwapper.___003C_003EMHC(obj2, num);
		return obj2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 84, 111, 107, 127, 6 })]
	private object toRefType(string P_0)
	{
		List list = HotSwapper.___003C_003EMHC(jvm, P_0);
		if (list == null || list.isEmpty())
		{
			string message = new StringBuilder().append("no such class: ").append(P_0).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(message);
		}
		object obj = list.get(0);
		if (obj != null)
		{
			obj = ByteCodeHelper.DynamicCast(obj, HotSwapper.___003C_003Eclass());
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<Lcom/sun/jdi/ReferenceType;[B>;Ljava/lang/String;)V")]
	[LineNumberTable(new byte[]
	{
		160, 91, 109, 102, 103, 107, 107, 107, 103, 99,
		103, 159, 6, 111
	})]
	private void reload2(Map P_0, string P_1)
	{
		lock (trigger)
		{
			startDaemon();
			newClassFiles = P_0;
			HotSwapper.___003C_003EMHC(request);
			trigger.doSwap();
			HotSwapper.___003C_003EMHC(request);
			Map map = newClassFiles;
			if (map != null)
			{
				newClassFiles = null;
				string message = new StringBuilder().append("failed to reload: ").append(P_1).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new RuntimeException(message);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 106, 230, 95, 103 })]
	private void startDaemon()
	{
		new _1(this).start();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "com.sun.jdi.connect.IllegalConnectorArgumentsException" })]
	[LineNumberTable(new byte[] { 61, 110 })]
	public HotSwapper(int port)
		: this(Integer.toString(port))
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 102, 126, 105 })]
	private void deleteEventRequest(object P_0, object P_1)
	{
		object obj = P_0;
		if (obj != null)
		{
			obj = ByteCodeHelper.DynamicCast(obj, HotSwapper.___003C_003Eclass());
		}
		object obj2 = P_1;
		if (obj2 != null)
		{
			obj2 = ByteCodeHelper.DynamicCast(obj2, HotSwapper.___003C_003Eclass());
		}
		HotSwapper.___003C_003EMHC(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 121, 104, 102, 127, 4, 106 })]
	public virtual void reload(string className, byte[] classFile)
	{
		object obj = toRefType(className);
		HashMap hashMap = new HashMap();
		((Map)hashMap).put(value: (object)classFile, key: (obj == null) ? null : ((obj as object) ?? throw new java.lang.IncompatibleClassChangeError()));
		reload2(hashMap, className);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<Ljava/lang/String;[B>;)V")]
	[LineNumberTable(new byte[]
	{
		160, 72, 102, 98, 127, 1, 108, 127, 22, 130,
		99, 127, 4
	})]
	public virtual void reload(Map classFiles)
	{
		HashMap hashMap = new HashMap();
		string text = null;
		Iterator iterator = classFiles.entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			text = (string)entry.getKey();
			object obj = toRefType(text);
			((Map)hashMap).put(value: (object)(byte[])entry.getValue(), key: (obj == null) ? null : ((obj as object) ?? throw new java.lang.IncompatibleClassChangeError()));
		}
		if (text != null)
		{
			reload2(hashMap, new StringBuilder().append(text).append(" etc.").toString());
		}
	}

	[LineNumberTable(101)]
	static HotSwapper()
	{
		TRIGGER_NAME = ClassLiteral<Trigger>.Value.getName();
	}

	static Class ___003C_003Eclass()
	{
		if (HotSwapper.m____003C_003Eclass == null)
		{
			HotSwapper.m____003C_003Eclass = ByteCodeHelper.DynamicClassLiteral("com.sun.jdi.connect.AttachingConnector", HotSwapper.___003CGetCallerID_003E());
		}
		return HotSwapper.m____003C_003Eclass;
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}

	static Map ___003C_003EMHC(object P_0)
	{
		if (HotSwapper.___003C_003EinvokeCache == null)
		{
			HotSwapper.___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MH<object, Map>>(9, "com.sun.jdi.connect.AttachingConnector", "defaultArguments", "()Ljava.util.Map;", HotSwapper.___003CGetCallerID_003E());
		}
		return HotSwapper.___003C_003EinvokeCache(P_0);
	}

	static Class ___003C_003Eclass()
	{
		if (HotSwapper.m____003C_003Eclass == null)
		{
			HotSwapper.m____003C_003Eclass = ByteCodeHelper.DynamicClassLiteral("com.sun.jdi.connect.Connector$Argument", HotSwapper.___003CGetCallerID_003E());
		}
		return HotSwapper.m____003C_003Eclass;
	}

	static void ___003C_003EMHC(object P_0, string P_1)
	{
		if (HotSwapper.___003C_003EinvokeCache == null)
		{
			HotSwapper.___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MHV<object, string>>(9, "com.sun.jdi.connect.Connector$Argument", "setValue", "(Ljava.lang.String;)V", HotSwapper.___003CGetCallerID_003E());
		}
		HotSwapper.___003C_003EinvokeCache(P_0, P_1);
	}

	static object ___003C_003EMHC(object P_0, Map P_1)
	{
		if (HotSwapper.___003C_003EinvokeCache == null)
		{
			HotSwapper.___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MH<object, Map, object>>(9, "com.sun.jdi.connect.AttachingConnector", "attach", "(Ljava.util.Map;)Lcom.sun.jdi.VirtualMachine;", HotSwapper.___003CGetCallerID_003E());
		}
		return HotSwapper.___003C_003EinvokeCache(P_0, P_1);
	}

	static object ___003C_003EMHC(object P_0)
	{
		if (HotSwapper.___003C_003EinvokeCache == null)
		{
			HotSwapper.___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MH<object, object>>(9, "com.sun.jdi.VirtualMachine", "eventRequestManager", "()Lcom.sun.jdi.request.EventRequestManager;", HotSwapper.___003CGetCallerID_003E());
		}
		return HotSwapper.___003C_003EinvokeCache(P_0);
	}

	static object ___003C_003EMHC()
	{
		if (HotSwapper.___003C_003EinvokeCache == null)
		{
			HotSwapper.___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MH<object>>(6, "com.sun.jdi.Bootstrap", "virtualMachineManager", "()Lcom.sun.jdi.VirtualMachineManager;", HotSwapper.___003CGetCallerID_003E());
		}
		return HotSwapper.___003C_003EinvokeCache();
	}

	static List ___003C_003EMHC(object P_0)
	{
		if (HotSwapper.___003C_003EinvokeCache == null)
		{
			HotSwapper.___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MH<object, List>>(9, "com.sun.jdi.VirtualMachineManager", "allConnectors", "()Ljava.util.List;", HotSwapper.___003CGetCallerID_003E());
		}
		return HotSwapper.___003C_003EinvokeCache(P_0);
	}

	static Class ___003C_003Eclass()
	{
		if (HotSwapper.m____003C_003Eclass == null)
		{
			HotSwapper.m____003C_003Eclass = ByteCodeHelper.DynamicClassLiteral("com.sun.jdi.connect.Connector", HotSwapper.___003CGetCallerID_003E());
		}
		return HotSwapper.m____003C_003Eclass;
	}

	static string ___003C_003EMHC(object P_0)
	{
		if (HotSwapper.___003C_003EinvokeCache == null)
		{
			HotSwapper.___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MH<object, string>>(9, "com.sun.jdi.connect.Connector", "name", "()Ljava.lang.String;", HotSwapper.___003CGetCallerID_003E());
		}
		return HotSwapper.___003C_003EinvokeCache(P_0);
	}

	static Class ___003C_003Eclass()
	{
		if (HotSwapper.m____003C_003Eclass == null)
		{
			HotSwapper.m____003C_003Eclass = ByteCodeHelper.DynamicClassLiteral("com.sun.jdi.request.EventRequestManager", HotSwapper.___003CGetCallerID_003E());
		}
		return HotSwapper.m____003C_003Eclass;
	}

	static object ___003C_003EMHC(object P_0)
	{
		if (HotSwapper.___003C_003EinvokeCache == null)
		{
			HotSwapper.___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MH<object, object>>(9, "com.sun.jdi.request.EventRequestManager", "createMethodEntryRequest", "()Lcom.sun.jdi.request.MethodEntryRequest;", HotSwapper.___003CGetCallerID_003E());
		}
		return HotSwapper.___003C_003EinvokeCache(P_0);
	}

	static void ___003C_003EMHC(object P_0, string P_1)
	{
		if (HotSwapper.___003C_003EinvokeCache == null)
		{
			HotSwapper.___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MHV<object, string>>(9, "com.sun.jdi.request.MethodEntryRequest", "addClassFilter", "(Ljava.lang.String;)V", HotSwapper.___003CGetCallerID_003E());
		}
		HotSwapper.___003C_003EinvokeCache(P_0, P_1);
	}

	static void ___003C_003EMHC(object P_0, int P_1)
	{
		if (HotSwapper.___003C_003EinvokeCache == null)
		{
			HotSwapper.___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MHV<object, int>>(9, "com.sun.jdi.request.MethodEntryRequest", "setSuspendPolicy", "(I)V", HotSwapper.___003CGetCallerID_003E());
		}
		HotSwapper.___003C_003EinvokeCache(P_0, P_1);
	}

	static Class ___003C_003Eclass()
	{
		if (HotSwapper.m____003C_003Eclass == null)
		{
			HotSwapper.m____003C_003Eclass = ByteCodeHelper.DynamicClassLiteral("com.sun.jdi.request.MethodEntryRequest", HotSwapper.___003CGetCallerID_003E());
		}
		return HotSwapper.m____003C_003Eclass;
	}

	static void ___003C_003EMHC(object P_0, object P_1)
	{
		if (HotSwapper.___003C_003EinvokeCache == null)
		{
			HotSwapper.___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MHV<object, object>>(9, "com.sun.jdi.request.EventRequestManager", "deleteEventRequest", "(Lcom.sun.jdi.request.EventRequest;)V", HotSwapper.___003CGetCallerID_003E());
		}
		HotSwapper.___003C_003EinvokeCache(P_0, P_1);
	}

	static List ___003C_003EMHC(object P_0, string P_1)
	{
		if (HotSwapper.___003C_003EinvokeCache == null)
		{
			HotSwapper.___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MH<object, string, List>>(9, "com.sun.jdi.VirtualMachine", "classesByName", "(Ljava.lang.String;)Ljava.util.List;", HotSwapper.___003CGetCallerID_003E());
		}
		return HotSwapper.___003C_003EinvokeCache(P_0, P_1);
	}

	static Class ___003C_003Eclass()
	{
		if (m____003C_003Eclass == null)
		{
			m____003C_003Eclass = ByteCodeHelper.DynamicClassLiteral("com.sun.jdi.ReferenceType", HotSwapper.___003CGetCallerID_003E());
		}
		return m____003C_003Eclass;
	}

	static void ___003C_003EMHC(object P_0)
	{
		if (HotSwapper.___003C_003EinvokeCache == null)
		{
			HotSwapper.___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MHV<object>>(9, "com.sun.jdi.request.MethodEntryRequest", "enable", "()V", HotSwapper.___003CGetCallerID_003E());
		}
		HotSwapper.___003C_003EinvokeCache(P_0);
	}

	static void ___003C_003EMHC(object P_0)
	{
		if (HotSwapper.___003C_003EinvokeCache == null)
		{
			HotSwapper.___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MHV<object>>(9, "com.sun.jdi.request.MethodEntryRequest", "disable", "()V", HotSwapper.___003CGetCallerID_003E());
		}
		HotSwapper.___003C_003EinvokeCache(P_0);
	}

	static object ___003C_003EMHC(object P_0)
	{
		if (HotSwapper.___003C_003EinvokeCache == null)
		{
			HotSwapper.___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MH<object, object>>(9, "com.sun.jdi.VirtualMachine", "eventQueue", "()Lcom.sun.jdi.event.EventQueue;", HotSwapper.___003CGetCallerID_003E());
		}
		return HotSwapper.___003C_003EinvokeCache(P_0);
	}

	static object ___003C_003EMHC(object P_0)
	{
		if (HotSwapper.___003C_003EinvokeCache == null)
		{
			HotSwapper.___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MH<object, object>>(9, "com.sun.jdi.event.EventQueue", "remove", "()Lcom.sun.jdi.event.EventSet;", HotSwapper.___003CGetCallerID_003E());
		}
		return HotSwapper.___003C_003EinvokeCache(P_0);
	}

	static void ___003C_003EMHC(object P_0, Map P_1)
	{
		if (___003C_003EinvokeCache == null)
		{
			___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MHV<object, Map>>(9, "com.sun.jdi.VirtualMachine", "redefineClasses", "(Ljava.util.Map;)V", HotSwapper.___003CGetCallerID_003E());
		}
		___003C_003EinvokeCache(P_0, P_1);
	}
}
