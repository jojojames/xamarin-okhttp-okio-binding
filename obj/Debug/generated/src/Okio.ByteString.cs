using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='ByteString']"
	[global::Android.Runtime.Register ("okio/ByteString", DoNotGenerateAcw=true)]
	public partial class ByteString : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Lang.IComparable {


		static IntPtr EMPTY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okio']/class[@name='ByteString']/field[@name='EMPTY']"
		[Register ("EMPTY")]
		public static global::Okio.ByteString Empty {
			get {
				if (EMPTY_jfieldId == IntPtr.Zero)
					EMPTY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY", "Lokio/ByteString;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMPTY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okio/ByteString", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ByteString); }
		}

		protected ByteString (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_base64;
#pragma warning disable 0169
		static Delegate GetBase64Handler ()
		{
			if (cb_base64 == null)
				cb_base64 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Base64);
			return cb_base64;
		}

		static IntPtr n_Base64 (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Base64 ());
		}
#pragma warning restore 0169

		static IntPtr id_base64;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='base64' and count(parameter)=0]"
		[Register ("base64", "()Ljava/lang/String;", "GetBase64Handler")]
		public virtual unsafe string Base64 ()
		{
			if (id_base64 == IntPtr.Zero)
				id_base64 = JNIEnv.GetMethodID (class_ref, "base64", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_base64), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "base64", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_base64Url;
#pragma warning disable 0169
		static Delegate GetBase64UrlHandler ()
		{
			if (cb_base64Url == null)
				cb_base64Url = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Base64Url);
			return cb_base64Url;
		}

		static IntPtr n_Base64Url (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Base64Url ());
		}
#pragma warning restore 0169

		static IntPtr id_base64Url;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='base64Url' and count(parameter)=0]"
		[Register ("base64Url", "()Ljava/lang/String;", "GetBase64UrlHandler")]
		public virtual unsafe string Base64Url ()
		{
			if (id_base64Url == IntPtr.Zero)
				id_base64Url = JNIEnv.GetMethodID (class_ref, "base64Url", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_base64Url), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "base64Url", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_compareTo_Lokio_ByteString_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lokio_ByteString_Handler ()
		{
			if (cb_compareTo_Lokio_ByteString_ == null)
				cb_compareTo_Lokio_ByteString_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lokio_ByteString_);
			return cb_compareTo_Lokio_ByteString_;
		}

		static int n_CompareTo_Lokio_ByteString_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.ByteString p0 = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lokio_ByteString_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
		[Register ("compareTo", "(Lokio/ByteString;)I", "GetCompareTo_Lokio_ByteString_Handler")]
		public virtual unsafe int CompareTo (global::Okio.ByteString p0)
		{
			if (id_compareTo_Lokio_ByteString_ == IntPtr.Zero)
				id_compareTo_Lokio_ByteString_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lokio/ByteString;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lokio_ByteString_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lokio/ByteString;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_decodeBase64_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='decodeBase64' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeBase64", "(Ljava/lang/String;)Lokio/ByteString;", "")]
		public static unsafe global::Okio.ByteString DecodeBase64 (string p0)
		{
			if (id_decodeBase64_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeBase64_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeBase64", "(Ljava/lang/String;)Lokio/ByteString;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Okio.ByteString __ret = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeBase64_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_decodeHex_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='decodeHex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeHex", "(Ljava/lang/String;)Lokio/ByteString;", "")]
		public static unsafe global::Okio.ByteString DecodeHex (string p0)
		{
			if (id_decodeHex_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeHex_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeHex", "(Ljava/lang/String;)Lokio/ByteString;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Okio.ByteString __ret = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeHex_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_encodeUtf8_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='encodeUtf8' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encodeUtf8", "(Ljava/lang/String;)Lokio/ByteString;", "")]
		public static unsafe global::Okio.ByteString EncodeUtf8 (string p0)
		{
			if (id_encodeUtf8_Ljava_lang_String_ == IntPtr.Zero)
				id_encodeUtf8_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encodeUtf8", "(Ljava/lang/String;)Lokio/ByteString;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Okio.ByteString __ret = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeUtf8_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getByte_I;
#pragma warning disable 0169
		static Delegate GetGetByte_IHandler ()
		{
			if (cb_getByte_I == null)
				cb_getByte_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, sbyte>) n_GetByte_I);
			return cb_getByte_I;
		}

		static sbyte n_GetByte_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetByte (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getByte_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='getByte' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getByte", "(I)B", "GetGetByte_IHandler")]
		public virtual unsafe sbyte GetByte (int p0)
		{
			if (id_getByte_I == IntPtr.Zero)
				id_getByte_I = JNIEnv.GetMethodID (class_ref, "getByte", "(I)B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallByteMethod  (Handle, id_getByte_I, __args);
				else
					return JNIEnv.CallNonvirtualByteMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getByte", "(I)B"), __args);
			} finally {
			}
		}

		static Delegate cb_hex;
#pragma warning disable 0169
		static Delegate GetHexHandler ()
		{
			if (cb_hex == null)
				cb_hex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Hex);
			return cb_hex;
		}

		static IntPtr n_Hex (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Hex ());
		}
#pragma warning restore 0169

		static IntPtr id_hex;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='hex' and count(parameter)=0]"
		[Register ("hex", "()Ljava/lang/String;", "GetHexHandler")]
		public virtual unsafe string Hex ()
		{
			if (id_hex == IntPtr.Zero)
				id_hex = JNIEnv.GetMethodID (class_ref, "hex", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_hex), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hex", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_md5;
#pragma warning disable 0169
		static Delegate GetMd5Handler ()
		{
			if (cb_md5 == null)
				cb_md5 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Md5);
			return cb_md5;
		}

		static IntPtr n_Md5 (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Md5 ());
		}
#pragma warning restore 0169

		static IntPtr id_md5;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='md5' and count(parameter)=0]"
		[Register ("md5", "()Lokio/ByteString;", "GetMd5Handler")]
		public virtual unsafe global::Okio.ByteString Md5 ()
		{
			if (id_md5 == IntPtr.Zero)
				id_md5 = JNIEnv.GetMethodID (class_ref, "md5", "()Lokio/ByteString;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallObjectMethod  (Handle, id_md5), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "md5", "()Lokio/ByteString;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_of_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='of' and count(parameter)=1 and parameter[1][@type='byte...']]"
		[Register ("of", "([B)Lokio/ByteString;", "")]
		public static unsafe global::Okio.ByteString Of (params  byte[] p0)
		{
			if (id_of_arrayB == IntPtr.Zero)
				id_of_arrayB = JNIEnv.GetStaticMethodID (class_ref, "of", "([B)Lokio/ByteString;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Okio.ByteString __ret = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallStaticObjectMethod  (class_ref, id_of_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_of_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='of' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("of", "([BII)Lokio/ByteString;", "")]
		public static unsafe global::Okio.ByteString Of (byte[] p0, int p1, int p2)
		{
			if (id_of_arrayBII == IntPtr.Zero)
				id_of_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "of", "([BII)Lokio/ByteString;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Okio.ByteString __ret = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallStaticObjectMethod  (class_ref, id_of_arrayBII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_rangeEquals_IarrayBII;
#pragma warning disable 0169
		static Delegate GetRangeEquals_IarrayBIIHandler ()
		{
			if (cb_rangeEquals_IarrayBII == null)
				cb_rangeEquals_IarrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int, int, bool>) n_RangeEquals_IarrayBII);
			return cb_rangeEquals_IarrayBII;
		}

		static bool n_RangeEquals_IarrayBII (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2, int p3)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.RangeEquals (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_rangeEquals_IarrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='rangeEquals' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("rangeEquals", "(I[BII)Z", "GetRangeEquals_IarrayBIIHandler")]
		public virtual unsafe bool RangeEquals (int p0, byte[] p1, int p2, int p3)
		{
			if (id_rangeEquals_IarrayBII == IntPtr.Zero)
				id_rangeEquals_IarrayBII = JNIEnv.GetMethodID (class_ref, "rangeEquals", "(I[BII)Z");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_rangeEquals_IarrayBII, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rangeEquals", "(I[BII)Z"), __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_rangeEquals_ILokio_ByteString_II;
#pragma warning disable 0169
		static Delegate GetRangeEquals_ILokio_ByteString_IIHandler ()
		{
			if (cb_rangeEquals_ILokio_ByteString_II == null)
				cb_rangeEquals_ILokio_ByteString_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int, int, bool>) n_RangeEquals_ILokio_ByteString_II);
			return cb_rangeEquals_ILokio_ByteString_II;
		}

		static bool n_RangeEquals_ILokio_ByteString_II (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2, int p3)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.ByteString p1 = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RangeEquals (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_rangeEquals_ILokio_ByteString_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='rangeEquals' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='okio.ByteString'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("rangeEquals", "(ILokio/ByteString;II)Z", "GetRangeEquals_ILokio_ByteString_IIHandler")]
		public virtual unsafe bool RangeEquals (int p0, global::Okio.ByteString p1, int p2, int p3)
		{
			if (id_rangeEquals_ILokio_ByteString_II == IntPtr.Zero)
				id_rangeEquals_ILokio_ByteString_II = JNIEnv.GetMethodID (class_ref, "rangeEquals", "(ILokio/ByteString;II)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_rangeEquals_ILokio_ByteString_II, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rangeEquals", "(ILokio/ByteString;II)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_read_Ljava_io_InputStream_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='read' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='int']]"
		[Register ("read", "(Ljava/io/InputStream;I)Lokio/ByteString;", "")]
		public static unsafe global::Okio.ByteString Read (global::System.IO.Stream p0, int p1)
		{
			if (id_read_Ljava_io_InputStream_I == IntPtr.Zero)
				id_read_Ljava_io_InputStream_I = JNIEnv.GetStaticMethodID (class_ref, "read", "(Ljava/io/InputStream;I)Lokio/ByteString;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Okio.ByteString __ret = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Ljava_io_InputStream_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sha256;
#pragma warning disable 0169
		static Delegate GetSha256Handler ()
		{
			if (cb_sha256 == null)
				cb_sha256 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Sha256);
			return cb_sha256;
		}

		static IntPtr n_Sha256 (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Sha256 ());
		}
#pragma warning restore 0169

		static IntPtr id_sha256;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='sha256' and count(parameter)=0]"
		[Register ("sha256", "()Lokio/ByteString;", "GetSha256Handler")]
		public virtual unsafe global::Okio.ByteString Sha256 ()
		{
			if (id_sha256 == IntPtr.Zero)
				id_sha256 = JNIEnv.GetMethodID (class_ref, "sha256", "()Lokio/ByteString;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallObjectMethod  (Handle, id_sha256), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sha256", "()Lokio/ByteString;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_size);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
			} finally {
			}
		}

		static Delegate cb_substring_I;
#pragma warning disable 0169
		static Delegate GetSubstring_IHandler ()
		{
			if (cb_substring_I == null)
				cb_substring_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Substring_I);
			return cb_substring_I;
		}

		static IntPtr n_Substring_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Substring (p0));
		}
#pragma warning restore 0169

		static IntPtr id_substring_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='substring' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("substring", "(I)Lokio/ByteString;", "GetSubstring_IHandler")]
		public virtual unsafe global::Okio.ByteString Substring (int p0)
		{
			if (id_substring_I == IntPtr.Zero)
				id_substring_I = JNIEnv.GetMethodID (class_ref, "substring", "(I)Lokio/ByteString;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallObjectMethod  (Handle, id_substring_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "substring", "(I)Lokio/ByteString;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_substring_II;
#pragma warning disable 0169
		static Delegate GetSubstring_IIHandler ()
		{
			if (cb_substring_II == null)
				cb_substring_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_Substring_II);
			return cb_substring_II;
		}

		static IntPtr n_Substring_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Substring (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_substring_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='substring' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("substring", "(II)Lokio/ByteString;", "GetSubstring_IIHandler")]
		public virtual unsafe global::Okio.ByteString Substring (int p0, int p1)
		{
			if (id_substring_II == IntPtr.Zero)
				id_substring_II = JNIEnv.GetMethodID (class_ref, "substring", "(II)Lokio/ByteString;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallObjectMethod  (Handle, id_substring_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "substring", "(II)Lokio/ByteString;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toAsciiLowercase;
#pragma warning disable 0169
		static Delegate GetToAsciiLowercaseHandler ()
		{
			if (cb_toAsciiLowercase == null)
				cb_toAsciiLowercase = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToAsciiLowercase);
			return cb_toAsciiLowercase;
		}

		static IntPtr n_ToAsciiLowercase (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToAsciiLowercase ());
		}
#pragma warning restore 0169

		static IntPtr id_toAsciiLowercase;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='toAsciiLowercase' and count(parameter)=0]"
		[Register ("toAsciiLowercase", "()Lokio/ByteString;", "GetToAsciiLowercaseHandler")]
		public virtual unsafe global::Okio.ByteString ToAsciiLowercase ()
		{
			if (id_toAsciiLowercase == IntPtr.Zero)
				id_toAsciiLowercase = JNIEnv.GetMethodID (class_ref, "toAsciiLowercase", "()Lokio/ByteString;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallObjectMethod  (Handle, id_toAsciiLowercase), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toAsciiLowercase", "()Lokio/ByteString;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toAsciiUppercase;
#pragma warning disable 0169
		static Delegate GetToAsciiUppercaseHandler ()
		{
			if (cb_toAsciiUppercase == null)
				cb_toAsciiUppercase = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToAsciiUppercase);
			return cb_toAsciiUppercase;
		}

		static IntPtr n_ToAsciiUppercase (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToAsciiUppercase ());
		}
#pragma warning restore 0169

		static IntPtr id_toAsciiUppercase;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='toAsciiUppercase' and count(parameter)=0]"
		[Register ("toAsciiUppercase", "()Lokio/ByteString;", "GetToAsciiUppercaseHandler")]
		public virtual unsafe global::Okio.ByteString ToAsciiUppercase ()
		{
			if (id_toAsciiUppercase == IntPtr.Zero)
				id_toAsciiUppercase = JNIEnv.GetMethodID (class_ref, "toAsciiUppercase", "()Lokio/ByteString;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallObjectMethod  (Handle, id_toAsciiUppercase), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toAsciiUppercase", "()Lokio/ByteString;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toByteArray;
#pragma warning disable 0169
		static Delegate GetToByteArrayHandler ()
		{
			if (cb_toByteArray == null)
				cb_toByteArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToByteArray);
			return cb_toByteArray;
		}

		static IntPtr n_ToByteArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToByteArray ());
		}
#pragma warning restore 0169

		static IntPtr id_toByteArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='toByteArray' and count(parameter)=0]"
		[Register ("toByteArray", "()[B", "GetToByteArrayHandler")]
		public virtual unsafe byte[] ToByteArray ()
		{
			if (id_toByteArray == IntPtr.Zero)
				id_toByteArray = JNIEnv.GetMethodID (class_ref, "toByteArray", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_toByteArray), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toByteArray", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_utf8;
#pragma warning disable 0169
		static Delegate GetUtf8Handler ()
		{
			if (cb_utf8 == null)
				cb_utf8 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Utf8);
			return cb_utf8;
		}

		static IntPtr n_Utf8 (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Utf8 ());
		}
#pragma warning restore 0169

		static IntPtr id_utf8;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='utf8' and count(parameter)=0]"
		[Register ("utf8", "()Ljava/lang/String;", "GetUtf8Handler")]
		public virtual unsafe string Utf8 ()
		{
			if (id_utf8 == IntPtr.Zero)
				id_utf8 = JNIEnv.GetMethodID (class_ref, "utf8", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_utf8), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "utf8", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_write_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_io_OutputStream_Handler ()
		{
			if (cb_write_Ljava_io_OutputStream_ == null)
				cb_write_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Ljava_io_OutputStream_);
			return cb_write_Ljava_io_OutputStream_;
		}

		static void n_Write_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okio.ByteString __this = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='ByteString']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("write", "(Ljava/io/OutputStream;)V", "GetWrite_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void Write (global::System.IO.Stream p0)
		{
			if (id_write_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_write_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Ljava_io_OutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/io/OutputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
