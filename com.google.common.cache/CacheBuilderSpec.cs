using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.concurrent;
using javax.annotation;

namespace com.google.common.cache;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/cache/ElementTypesAreNonnullByDefault;"
})]
public sealed class CacheBuilderSpec : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		internal static int[] _0024SwitchMap_0024com_0024google_0024common_0024cache_0024LocalCache_0024Strength;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[LineNumberTable(184)]
		static _1()
		{
			_0024SwitchMap_0024com_0024google_0024common_0024cache_0024LocalCache_0024Strength = new int[(nint)LocalCache.Strength.values().LongLength];
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024cache_0024LocalCache_0024Strength[LocalCache.Strength.WEAK.ordinal()] = 1;
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0033;
			}
			goto IL_0039;
			IL_0033:
			_ = null;
			goto IL_0039;
			IL_0039:
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024cache_0024LocalCache_0024Strength[LocalCache.Strength.SOFT.ordinal()] = 2;
				return;
			}
			catch (System.Exception x2)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x2, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
			}
			_ = null;
		}

		_1()
		{
			throw null;
		}
	}

	internal class AccessDurationParser : DurationParser
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(456)]
		internal AccessDurationParser()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 89, 118, 103, 103 })]
		protected internal override void parseDuration(CacheBuilderSpec P_0, long P_1, TimeUnit P_2)
		{
			Preconditions.checkArgument(P_0.accessExpirationTimeUnit == null, (object)"expireAfterAccess already set");
			P_0.accessExpirationDuration = P_1;
			P_0.accessExpirationTimeUnit = P_2;
		}
	}

	internal class ConcurrencyLevelParser : IntegerParser
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(360)]
		internal ConcurrencyLevelParser()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 249, 220, 108 })]
		protected internal override void parseInteger(CacheBuilderSpec P_0, int P_1)
		{
			Preconditions.checkArgument(P_0.concurrencyLevel == null, "concurrency level was already set to ", P_0.concurrencyLevel);
			P_0.concurrencyLevel = Integer.valueOf(P_1);
		}
	}

	internal abstract class DurationParser : java.lang.Object, ValueParser
	{
		protected internal abstract void parseDuration(CacheBuilderSpec P_0, long P_1, TimeUnit P_2);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(417)]
		internal DurationParser()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 52, 104, 191, 34, 143, 159, 5, 102, 130,
			102, 130, 102, 130, 102, 130, 115, 176, 117, 212,
			226, 61, 97, 115, 144
		})]
		public virtual void parse(CacheBuilderSpec P_0, string P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] string P_2)
		{
			if (Strings.isNullOrEmpty(P_2))
			{
				int num = 21 + java.lang.String.instancehelper_length(java.lang.String.valueOf(P_1));
				num = num;
				string s = new StringBuilder(num).append("value of key ").append(P_1).append(" omitted")
					.toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalArgumentException(s);
			}
			try
			{
				TimeUnit timeUnit;
				switch (java.lang.String.instancehelper_charAt(P_2, java.lang.String.instancehelper_length(P_2) - 1))
				{
				case 'd':
					timeUnit = TimeUnit.DAYS;
					break;
				case 'h':
					timeUnit = TimeUnit.HOURS;
					break;
				case 'm':
					timeUnit = TimeUnit.MINUTES;
					break;
				case 's':
					timeUnit = TimeUnit.SECONDS;
					break;
				default:
				{
					string s2 = access_0024000("key %s invalid unit: was %s, must end with one of [dhms]", new object[2] { P_1, P_2 });
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new IllegalArgumentException(s2);
				}
				}
				long num2 = Long.parseLong(java.lang.String.instancehelper_substring(P_2, 0, java.lang.String.instancehelper_length(P_2) - 1));
				parseDuration(P_0, num2, timeUnit);
				return;
			}
			catch (NumberFormatException)
			{
			}
			_ = null;
			string s3 = access_0024000("key %s value set to %s, must be integer", new object[2] { P_1, P_2 });
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s3);
		}
	}

	internal class InitialCapacityParser : IntegerParser
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(326)]
		internal InitialCapacityParser()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 215, 220, 108 })]
		protected internal override void parseInteger(CacheBuilderSpec P_0, int P_1)
		{
			Preconditions.checkArgument(P_0.initialCapacity == null, "initial capacity was already set to ", P_0.initialCapacity);
			P_0.initialCapacity = Integer.valueOf(P_1);
		}
	}

	[ConstantPool(new object[]
	{
		(byte)44,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class IntegerParser : java.lang.Object, ValueParser
	{
		protected internal abstract void parseInteger(CacheBuilderSpec P_0, int P_1);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(290)]
		internal IntegerParser()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 44, 0, 0 })]
		[LineNumberTable(new byte[]
		{
			160, 181, 104, 191, 34, 223, 0, 226, 61, 97,
			115, 145
		})]
		public virtual void parse(CacheBuilderSpec P_0, string P_1, string P_2)
		{
			if (Strings.isNullOrEmpty(P_2))
			{
				int num = 21 + java.lang.String.instancehelper_length(java.lang.String.valueOf(P_1));
				num = num;
				string s = new StringBuilder(num).append("value of key ").append(P_1).append(" omitted")
					.toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalArgumentException(s);
			}
			NumberFormatException ex;
			try
			{
				parseInteger(P_0, Integer.parseInt(P_2));
				return;
			}
			catch (NumberFormatException x)
			{
				ex = ByteCodeHelper.MapException<NumberFormatException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			NumberFormatException cause = ex;
			string message = access_0024000("key %s value set to %s, must be integer", new object[2] { P_1, P_2 });
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(message, cause);
		}
	}

	internal class KeyStrengthParser : java.lang.Object, ValueParser
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private LocalCache.Strength strength;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 5, 104, 103 })]
		public KeyStrengthParser(LocalCache.Strength P_0)
		{
			strength = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 11, 114, 125, 108 })]
		public virtual void parse(CacheBuilderSpec P_0, string P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] string P_2)
		{
			Preconditions.checkArgument(P_2 == null, "key %s does not take values", P_1);
			Preconditions.checkArgument(P_0.keyStrength == null, "%s was already set to %s", P_1, P_0.keyStrength);
			P_0.keyStrength = strength;
		}
	}

	[ConstantPool(new object[]
	{
		(byte)44,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class LongParser : java.lang.Object, ValueParser
	{
		protected internal abstract void parseLong(CacheBuilderSpec P_0, long P_1);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(308)]
		internal LongParser()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 44, 0, 0 })]
		[LineNumberTable(new byte[]
		{
			160, 199, 104, 191, 34, 223, 0, 226, 61, 97,
			115, 145
		})]
		public virtual void parse(CacheBuilderSpec P_0, string P_1, string P_2)
		{
			if (Strings.isNullOrEmpty(P_2))
			{
				int num = 21 + java.lang.String.instancehelper_length(java.lang.String.valueOf(P_1));
				num = num;
				string s = new StringBuilder(num).append("value of key ").append(P_1).append(" omitted")
					.toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalArgumentException(s);
			}
			NumberFormatException ex;
			try
			{
				parseLong(P_0, Long.parseLong(P_2));
				return;
			}
			catch (NumberFormatException x)
			{
				ex = ByteCodeHelper.MapException<NumberFormatException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			NumberFormatException cause = ex;
			string message = access_0024000("key %s value set to %s, must be integer", new object[2] { P_1, P_2 });
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(message, cause);
		}
	}

	internal class MaximumSizeParser : LongParser
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(338)]
		internal MaximumSizeParser()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 227, 124, 156, 108 })]
		protected internal override void parseLong(CacheBuilderSpec P_0, long P_1)
		{
			Preconditions.checkArgument(P_0.maximumSize == null, "maximum size was already set to ", P_0.maximumSize);
			Preconditions.checkArgument(P_0.maximumWeight == null, "maximum weight was already set to ", P_0.maximumWeight);
			P_0.maximumSize = Long.valueOf(P_1);
		}
	}

	internal class MaximumWeightParser : LongParser
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(349)]
		internal MaximumWeightParser()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 238, 156, 124, 108 })]
		protected internal override void parseLong(CacheBuilderSpec P_0, long P_1)
		{
			Preconditions.checkArgument(P_0.maximumWeight == null, "maximum weight was already set to ", P_0.maximumWeight);
			Preconditions.checkArgument(P_0.maximumSize == null, "maximum size was already set to ", P_0.maximumSize);
			P_0.maximumWeight = Long.valueOf(P_1);
		}
	}

	internal class RecordStatsParser : java.lang.Object, ValueParser
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(406)]
		internal RecordStatsParser()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 40, 113, 118, 108 })]
		public virtual void parse(CacheBuilderSpec P_0, string P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] string P_2)
		{
			Preconditions.checkArgument(P_2 == null, (object)"recordStats does not take values");
			Preconditions.checkArgument(P_0.recordStats == null, (object)"recordStats already set");
			P_0.recordStats = java.lang.Boolean.valueOf(b: true);
		}
	}

	internal class RefreshDurationParser : DurationParser
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(476)]
		internal RefreshDurationParser()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 109, 118, 103, 103 })]
		protected internal override void parseDuration(CacheBuilderSpec P_0, long P_1, TimeUnit P_2)
		{
			Preconditions.checkArgument(P_0.refreshTimeUnit == null, (object)"refreshAfterWrite already set");
			P_0.refreshDuration = P_1;
			P_0.refreshTimeUnit = P_2;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Interface | Modifiers.Abstract)]
	internal interface ValueParser
	{
		virtual void parse(CacheBuilderSpec P_0, string P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] string P_2);
	}

	internal class ValueStrengthParser : java.lang.Object, ValueParser
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private LocalCache.Strength strength;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 21, 104, 103 })]
		public ValueStrengthParser(LocalCache.Strength P_0)
		{
			strength = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 27, 114, 189, 108 })]
		public virtual void parse(CacheBuilderSpec P_0, string P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] string P_2)
		{
			Preconditions.checkArgument(P_2 == null, "key %s does not take values", P_1);
			Preconditions.checkArgument(P_0.valueStrength == null, "%s was already set to %s", P_1, P_0.valueStrength);
			P_0.valueStrength = strength;
		}
	}

	internal class WriteDurationParser : DurationParser
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(466)]
		internal WriteDurationParser()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 99, 118, 103, 103 })]
		protected internal override void parseDuration(CacheBuilderSpec P_0, long P_1, TimeUnit P_2)
		{
			Preconditions.checkArgument(P_0.writeExpirationTimeUnit == null, (object)"expireAfterWrite already set");
			P_0.writeExpirationDuration = P_1;
			P_0.writeExpirationTimeUnit = P_2;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Splitter KEYS_SPLITTER;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Splitter KEY_VALUE_SPLITTER;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableMap<Ljava/lang/String;Lcom/google/common/cache/CacheBuilderSpec$ValueParser;>;")]
	private static ImmutableMap VALUE_PARSERS;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal Integer initialCapacity;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal Long maximumSize;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal Long maximumWeight;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal Integer concurrencyLevel;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal LocalCache.Strength keyStrength;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal LocalCache.Strength valueStrength;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal java.lang.Boolean recordStats;

	internal long writeExpirationDuration;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal TimeUnit writeExpirationTimeUnit;

	internal long accessExpirationDuration;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal TimeUnit accessExpirationTimeUnit;

	internal long refreshDuration;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal TimeUnit refreshTimeUnit;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private string specification;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/cache/CacheBuilder<Ljava/lang/Object;Ljava/lang/Object;>;")]
	[LineNumberTable(new byte[]
	{
		120, 102, 104, 146, 104, 146, 104, 146, 104, 146,
		104, 155, 103, 130, 171, 104, 159, 3, 103, 130,
		103, 130, 171, 117, 135, 104, 147, 104, 147, 104,
		179
	})]
	internal virtual CacheBuilder toCacheBuilder()
	{
		CacheBuilder cacheBuilder = CacheBuilder.newBuilder();
		if (initialCapacity != null)
		{
			cacheBuilder.initialCapacity(initialCapacity.intValue());
		}
		if (maximumSize != null)
		{
			cacheBuilder.maximumSize(maximumSize.longValue());
		}
		if (maximumWeight != null)
		{
			cacheBuilder.maximumWeight(maximumWeight.longValue());
		}
		if (concurrencyLevel != null)
		{
			cacheBuilder.concurrencyLevel(concurrencyLevel.intValue());
		}
		if (keyStrength != null)
		{
			if (_1._0024SwitchMap_0024com_0024google_0024common_0024cache_0024LocalCache_0024Strength[keyStrength.ordinal()] != 1)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError();
			}
			cacheBuilder.weakKeys();
		}
		if (valueStrength != null)
		{
			switch (_1._0024SwitchMap_0024com_0024google_0024common_0024cache_0024LocalCache_0024Strength[valueStrength.ordinal()])
			{
			case 2:
				cacheBuilder.softValues();
				break;
			case 1:
				cacheBuilder.weakValues();
				break;
			default:
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError();
			}
		}
		if (recordStats != null && recordStats.booleanValue())
		{
			cacheBuilder.recordStats();
		}
		if (writeExpirationTimeUnit != null)
		{
			cacheBuilder.expireAfterWrite(writeExpirationDuration, writeExpirationTimeUnit);
		}
		if (accessExpirationTimeUnit != null)
		{
			cacheBuilder.expireAfterAccess(accessExpirationDuration, accessExpirationTimeUnit);
		}
		if (refreshTimeUnit != null)
		{
			cacheBuilder.refreshAfterWrite(refreshDuration, refreshTimeUnit);
		}
		return cacheBuilder;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		89, 103, 107, 127, 26, 127, 4, 119, 98, 50,
		229, 70, 111, 115, 148, 124, 108, 165
	})]
	public static CacheBuilderSpec parse(string cacheBuilderSpecification)
	{
		CacheBuilderSpec cacheBuilderSpec = new CacheBuilderSpec(cacheBuilderSpecification);
		if (!java.lang.String.instancehelper_isEmpty(cacheBuilderSpecification))
		{
			Splitter kEYS_SPLITTER = KEYS_SPLITTER;
			CharSequence sequence = default(CharSequence);
			object obj = (sequence.___003Cref_003E = cacheBuilderSpecification);
			Iterator iterator = kEYS_SPLITTER.split(sequence).iterator();
			while (iterator.hasNext())
			{
				string text = (string)iterator.next();
				Splitter kEY_VALUE_SPLITTER = KEY_VALUE_SPLITTER;
				obj = (sequence.___003Cref_003E = text);
				ImmutableList immutableList = ImmutableList.copyOf(kEY_VALUE_SPLITTER.split(sequence));
				Preconditions.checkArgument((!((List)immutableList).isEmpty()) ? true : false, (object)"blank key-value pair");
				Preconditions.checkArgument(((List)immutableList).size() <= 2, "key-value pair %s with more than one equals sign", text);
				string text2 = (string)((List)immutableList).get(0);
				ValueParser valueParser = (ValueParser)VALUE_PARSERS.get(text2);
				Preconditions.checkArgument(valueParser != null, "unknown key %s", text2);
				string text3 = ((((List)immutableList).size() != 1) ? ((string)((List)immutableList).get(1)) : null);
				valueParser.parse(cacheBuilderSpec, text2, text3);
			}
		}
		return cacheBuilderSpec;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(486)]
	private static string format(string P_0, params object[] P_1)
	{
		string result = java.lang.String.format(Locale.ROOT, P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 79, 104, 103 })]
	private CacheBuilderSpec(string P_0)
	{
		specification = P_0;
	}

	public virtual string toParsableString()
	{
		return specification;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(286)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static Long durationInNanos(long P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] TimeUnit P_1)
	{
		Long result = ((P_1 != null) ? Long.valueOf(P_1.toNanos(P_0)) : null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(165)]
	public static CacheBuilderSpec disableCaching()
	{
		CacheBuilderSpec result = parse("maximumSize=0");
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(235)]
	public override string toString()
	{
		string result = MoreObjects.toStringHelper(this).addValue(toParsableString()).toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160,
		126,
		byte.MaxValue,
		53,
		72,
		116,
		117,
		230,
		54
	})]
	public override int hashCode()
	{
		int result = com.google.common.@base.Objects.hashCode(initialCapacity, maximumSize, maximumWeight, concurrencyLevel, keyStrength, valueStrength, recordStats, durationInNanos(writeExpirationDuration, writeExpirationTimeUnit), durationInNanos(accessExpirationDuration, accessExpirationTimeUnit), durationInNanos(refreshDuration, refreshTimeUnit));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 141, 100, 130, 104, 130, 103, 127, 3, 118,
		118, 118, 118, 118, 150, 113, 5, 211, 113, 5,
		211, 113, 5, 235, 51
	})]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		if (this == obj)
		{
			return true;
		}
		if (!(obj is CacheBuilderSpec))
		{
			return false;
		}
		CacheBuilderSpec cacheBuilderSpec = (CacheBuilderSpec)obj;
		return (com.google.common.@base.Objects.equal(initialCapacity, cacheBuilderSpec.initialCapacity) && com.google.common.@base.Objects.equal(maximumSize, cacheBuilderSpec.maximumSize) && com.google.common.@base.Objects.equal(maximumWeight, cacheBuilderSpec.maximumWeight) && com.google.common.@base.Objects.equal(concurrencyLevel, cacheBuilderSpec.concurrencyLevel) && com.google.common.@base.Objects.equal(keyStrength, cacheBuilderSpec.keyStrength) && com.google.common.@base.Objects.equal(valueStrength, cacheBuilderSpec.valueStrength) && com.google.common.@base.Objects.equal(recordStats, cacheBuilderSpec.recordStats) && com.google.common.@base.Objects.equal(durationInNanos(writeExpirationDuration, writeExpirationTimeUnit), durationInNanos(cacheBuilderSpec.writeExpirationDuration, cacheBuilderSpec.writeExpirationTimeUnit)) && com.google.common.@base.Objects.equal(durationInNanos(accessExpirationDuration, accessExpirationTimeUnit), durationInNanos(cacheBuilderSpec.accessExpirationDuration, cacheBuilderSpec.accessExpirationTimeUnit)) && com.google.common.@base.Objects.equal(durationInNanos(refreshDuration, refreshTimeUnit), durationInNanos(cacheBuilderSpec.refreshDuration, cacheBuilderSpec.refreshTimeUnit))) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(84)]
	internal static string access_0024000(string P_0, object[] P_1)
	{
		string result = format(P_0, P_1);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[]
	{
		41, 177, 209, 111, 111, 111, 111, 116, 116, 116,
		111, 111, 111, 111, 111, 101, 234, 50
	})]
	static CacheBuilderSpec()
	{
		KEYS_SPLITTER = Splitter.on(',').trimResults();
		KEY_VALUE_SPLITTER = Splitter.on('=').trimResults();
		VALUE_PARSERS = ImmutableMap.builder().put("initialCapacity", new InitialCapacityParser()).put("maximumSize", new MaximumSizeParser())
			.put("maximumWeight", new MaximumWeightParser())
			.put("concurrencyLevel", new ConcurrencyLevelParser())
			.put("weakKeys", new KeyStrengthParser(LocalCache.Strength.WEAK))
			.put("softValues", new ValueStrengthParser(LocalCache.Strength.SOFT))
			.put("weakValues", new ValueStrengthParser(LocalCache.Strength.WEAK))
			.put("recordStats", new RecordStatsParser())
			.put("expireAfterAccess", new AccessDurationParser())
			.put("expireAfterWrite", new WriteDurationParser())
			.put("refreshAfterWrite", new RefreshDurationParser())
			.put("refreshInterval", new RefreshDurationParser())
			.buildOrThrow();
	}
}
