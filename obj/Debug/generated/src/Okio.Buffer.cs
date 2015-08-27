using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='Buffer']"
	[global::Android.Runtime.Register ("okio/Buffer", DoNotGenerateAcw=true)]
	public sealed partial class Buffer : global::Java.Lang.Object, global::Java.Lang.ICloneable, global::Okio.IBufferedSink, global::Okio.IBufferedSource {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okio/Buffer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Buffer); }
		}

		internal Buffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okio']/class[@name='Buffer']/constructor[@name='Buffer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Buffer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Buffer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_buffer;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='buffer' and count(parameter)=0]"
		[Register ("buffer", "()Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer InvokeBuffer ()
		{
			if (id_buffer == IntPtr.Zero)
				id_buffer = JNIEnv.GetMethodID (class_ref, "buffer", "()Lokio/Buffer;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (JNIEnv.CallObjectMethod  (Handle, id_buffer), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_clear);
			} finally {
			}
		}

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lokio/Buffer;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okio.Buffer> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_close);
			} finally {
			}
		}

		static IntPtr id_completeSegmentByteCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='completeSegmentByteCount' and count(parameter)=0]"
		[Register ("completeSegmentByteCount", "()J", "")]
		public unsafe long CompleteSegmentByteCount ()
		{
			if (id_completeSegmentByteCount == IntPtr.Zero)
				id_completeSegmentByteCount = JNIEnv.GetMethodID (class_ref, "completeSegmentByteCount", "()J");
			try {
				return JNIEnv.CallLongMethod  (Handle, id_completeSegmentByteCount);
			} finally {
			}
		}

		static IntPtr id_copyTo_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='copyTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("copyTo", "(Ljava/io/OutputStream;)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer CopyTo (global::System.IO.Stream p0)
		{
			if (id_copyTo_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_copyTo_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "copyTo", "(Ljava/io/OutputStream;)Lokio/Buffer;");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Okio.Buffer __ret = global::Java.Lang.Object.GetObject<global::Okio.Buffer> (JNIEnv.CallObjectMethod  (Handle, id_copyTo_Ljava_io_OutputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_copyTo_Ljava_io_OutputStream_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='copyTo' and count(parameter)=3 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("copyTo", "(Ljava/io/OutputStream;JJ)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer CopyTo (global::System.IO.Stream p0, long p1, long p2)
		{
			if (id_copyTo_Ljava_io_OutputStream_JJ == IntPtr.Zero)
				id_copyTo_Ljava_io_OutputStream_JJ = JNIEnv.GetMethodID (class_ref, "copyTo", "(Ljava/io/OutputStream;JJ)Lokio/Buffer;");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Okio.Buffer __ret = global::Java.Lang.Object.GetObject<global::Okio.Buffer> (JNIEnv.CallObjectMethod  (Handle, id_copyTo_Ljava_io_OutputStream_JJ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_copyTo_Lokio_Buffer_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='copyTo' and count(parameter)=3 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("copyTo", "(Lokio/Buffer;JJ)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer CopyTo (global::Okio.Buffer p0, long p1, long p2)
		{
			if (id_copyTo_Lokio_Buffer_JJ == IntPtr.Zero)
				id_copyTo_Lokio_Buffer_JJ = JNIEnv.GetMethodID (class_ref, "copyTo", "(Lokio/Buffer;JJ)Lokio/Buffer;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Okio.Buffer __ret = global::Java.Lang.Object.GetObject<global::Okio.Buffer> (JNIEnv.CallObjectMethod  (Handle, id_copyTo_Lokio_Buffer_JJ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_emit;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='emit' and count(parameter)=0]"
		[Register ("emit", "()Lokio/BufferedSink;", "")]
		public unsafe global::Okio.IBufferedSink Emit ()
		{
			if (id_emit == IntPtr.Zero)
				id_emit = JNIEnv.GetMethodID (class_ref, "emit", "()Lokio/BufferedSink;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod  (Handle, id_emit), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_emitCompleteSegments;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='emitCompleteSegments' and count(parameter)=0]"
		[Register ("emitCompleteSegments", "()Lokio/Buffer;", "")]
		public unsafe global::Okio.IBufferedSink EmitCompleteSegments ()
		{
			if (id_emitCompleteSegments == IntPtr.Zero)
				id_emitCompleteSegments = JNIEnv.GetMethodID (class_ref, "emitCompleteSegments", "()Lokio/Buffer;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod  (Handle, id_emitCompleteSegments), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_exhausted;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='exhausted' and count(parameter)=0]"
		[Register ("exhausted", "()Z", "")]
		public unsafe bool Exhausted ()
		{
			if (id_exhausted == IntPtr.Zero)
				id_exhausted = JNIEnv.GetMethodID (class_ref, "exhausted", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_exhausted);
			} finally {
			}
		}

		static IntPtr id_flush;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "")]
		public unsafe void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_flush);
			} finally {
			}
		}

		static IntPtr id_getByte_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='getByte' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getByte", "(J)B", "")]
		public unsafe sbyte GetByte (long p0)
		{
			if (id_getByte_J == IntPtr.Zero)
				id_getByte_J = JNIEnv.GetMethodID (class_ref, "getByte", "(J)B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallByteMethod  (Handle, id_getByte_J, __args);
			} finally {
			}
		}

		static IntPtr id_indexOf_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("indexOf", "(B)J", "")]
		public unsafe long IndexOf (sbyte p0)
		{
			if (id_indexOf_B == IntPtr.Zero)
				id_indexOf_B = JNIEnv.GetMethodID (class_ref, "indexOf", "(B)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallLongMethod  (Handle, id_indexOf_B, __args);
			} finally {
			}
		}

		static IntPtr id_indexOf_BJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='long']]"
		[Register ("indexOf", "(BJ)J", "")]
		public unsafe long IndexOf (sbyte p0, long p1)
		{
			if (id_indexOf_BJ == IntPtr.Zero)
				id_indexOf_BJ = JNIEnv.GetMethodID (class_ref, "indexOf", "(BJ)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallLongMethod  (Handle, id_indexOf_BJ, __args);
			} finally {
			}
		}

		static IntPtr id_indexOf_Lokio_ByteString_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
		[Register ("indexOf", "(Lokio/ByteString;)J", "")]
		public unsafe long IndexOf (global::Okio.ByteString p0)
		{
			if (id_indexOf_Lokio_ByteString_ == IntPtr.Zero)
				id_indexOf_Lokio_ByteString_ = JNIEnv.GetMethodID (class_ref, "indexOf", "(Lokio/ByteString;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallLongMethod  (Handle, id_indexOf_Lokio_ByteString_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_indexOf_Lokio_ByteString_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='okio.ByteString'] and parameter[2][@type='long']]"
		[Register ("indexOf", "(Lokio/ByteString;J)J", "")]
		public unsafe long IndexOf (global::Okio.ByteString p0, long p1)
		{
			if (id_indexOf_Lokio_ByteString_J == IntPtr.Zero)
				id_indexOf_Lokio_ByteString_J = JNIEnv.GetMethodID (class_ref, "indexOf", "(Lokio/ByteString;J)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				long __ret = JNIEnv.CallLongMethod  (Handle, id_indexOf_Lokio_ByteString_J, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_indexOfElement_Lokio_ByteString_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='indexOfElement' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
		[Register ("indexOfElement", "(Lokio/ByteString;)J", "")]
		public unsafe long IndexOfElement (global::Okio.ByteString p0)
		{
			if (id_indexOfElement_Lokio_ByteString_ == IntPtr.Zero)
				id_indexOfElement_Lokio_ByteString_ = JNIEnv.GetMethodID (class_ref, "indexOfElement", "(Lokio/ByteString;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallLongMethod  (Handle, id_indexOfElement_Lokio_ByteString_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_indexOfElement_Lokio_ByteString_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='indexOfElement' and count(parameter)=2 and parameter[1][@type='okio.ByteString'] and parameter[2][@type='long']]"
		[Register ("indexOfElement", "(Lokio/ByteString;J)J", "")]
		public unsafe long IndexOfElement (global::Okio.ByteString p0, long p1)
		{
			if (id_indexOfElement_Lokio_ByteString_J == IntPtr.Zero)
				id_indexOfElement_Lokio_ByteString_J = JNIEnv.GetMethodID (class_ref, "indexOfElement", "(Lokio/ByteString;J)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				long __ret = JNIEnv.CallLongMethod  (Handle, id_indexOfElement_Lokio_ByteString_J, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_inputStream;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='inputStream' and count(parameter)=0]"
		[Register ("inputStream", "()Ljava/io/InputStream;", "")]
		public unsafe global::System.IO.Stream InputStream ()
		{
			if (id_inputStream == IntPtr.Zero)
				id_inputStream = JNIEnv.GetMethodID (class_ref, "inputStream", "()Ljava/io/InputStream;");
			try {
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_inputStream), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_outputStream;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='outputStream' and count(parameter)=0]"
		[Register ("outputStream", "()Ljava/io/OutputStream;", "")]
		public unsafe global::System.IO.Stream OutputStream ()
		{
			if (id_outputStream == IntPtr.Zero)
				id_outputStream = JNIEnv.GetMethodID (class_ref, "outputStream", "()Ljava/io/OutputStream;");
			try {
				return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_outputStream), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_read_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='read' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("read", "([B)I", "")]
		public unsafe int Read (byte[] p0)
		{
			if (id_read_arrayB == IntPtr.Zero)
				id_read_arrayB = JNIEnv.GetMethodID (class_ref, "read", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod  (Handle, id_read_arrayB, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_read_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("read", "([BII)I", "")]
		public unsafe int Read (byte[] p0, int p1, int p2)
		{
			if (id_read_arrayBII == IntPtr.Zero)
				id_read_arrayBII = JNIEnv.GetMethodID (class_ref, "read", "([BII)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallIntMethod  (Handle, id_read_arrayBII, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_read_Lokio_Buffer_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='read' and count(parameter)=2 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long']]"
		[Register ("read", "(Lokio/Buffer;J)J", "")]
		public unsafe long Read (global::Okio.Buffer p0, long p1)
		{
			if (id_read_Lokio_Buffer_J == IntPtr.Zero)
				id_read_Lokio_Buffer_J = JNIEnv.GetMethodID (class_ref, "read", "(Lokio/Buffer;J)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				long __ret = JNIEnv.CallLongMethod  (Handle, id_read_Lokio_Buffer_J, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readAll_Lokio_Sink_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readAll' and count(parameter)=1 and parameter[1][@type='okio.Sink']]"
		[Register ("readAll", "(Lokio/Sink;)J", "")]
		public unsafe long ReadAll (global::Okio.ISink p0)
		{
			if (id_readAll_Lokio_Sink_ == IntPtr.Zero)
				id_readAll_Lokio_Sink_ = JNIEnv.GetMethodID (class_ref, "readAll", "(Lokio/Sink;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallLongMethod  (Handle, id_readAll_Lokio_Sink_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readByte;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readByte' and count(parameter)=0]"
		[Register ("readByte", "()B", "")]
		public unsafe sbyte ReadByte ()
		{
			if (id_readByte == IntPtr.Zero)
				id_readByte = JNIEnv.GetMethodID (class_ref, "readByte", "()B");
			try {
				return JNIEnv.CallByteMethod  (Handle, id_readByte);
			} finally {
			}
		}

		static IntPtr id_readByteArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readByteArray' and count(parameter)=0]"
		[Register ("readByteArray", "()[B", "")]
		public unsafe byte[] ReadByteArray ()
		{
			if (id_readByteArray == IntPtr.Zero)
				id_readByteArray = JNIEnv.GetMethodID (class_ref, "readByteArray", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_readByteArray), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_readByteArray_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readByteArray' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("readByteArray", "(J)[B", "")]
		public unsafe byte[] ReadByteArray (long p0)
		{
			if (id_readByteArray_J == IntPtr.Zero)
				id_readByteArray_J = JNIEnv.GetMethodID (class_ref, "readByteArray", "(J)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_readByteArray_J, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_readByteString;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readByteString' and count(parameter)=0]"
		[Register ("readByteString", "()Lokio/ByteString;", "")]
		public unsafe global::Okio.ByteString ReadByteString ()
		{
			if (id_readByteString == IntPtr.Zero)
				id_readByteString = JNIEnv.GetMethodID (class_ref, "readByteString", "()Lokio/ByteString;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallObjectMethod  (Handle, id_readByteString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_readByteString_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readByteString' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("readByteString", "(J)Lokio/ByteString;", "")]
		public unsafe global::Okio.ByteString ReadByteString (long p0)
		{
			if (id_readByteString_J == IntPtr.Zero)
				id_readByteString_J = JNIEnv.GetMethodID (class_ref, "readByteString", "(J)Lokio/ByteString;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallObjectMethod  (Handle, id_readByteString_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_readDecimalLong;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readDecimalLong' and count(parameter)=0]"
		[Register ("readDecimalLong", "()J", "")]
		public unsafe long ReadDecimalLong ()
		{
			if (id_readDecimalLong == IntPtr.Zero)
				id_readDecimalLong = JNIEnv.GetMethodID (class_ref, "readDecimalLong", "()J");
			try {
				return JNIEnv.CallLongMethod  (Handle, id_readDecimalLong);
			} finally {
			}
		}

		static IntPtr id_readFrom_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readFrom' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("readFrom", "(Ljava/io/InputStream;)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer ReadFrom (global::System.IO.Stream p0)
		{
			if (id_readFrom_Ljava_io_InputStream_ == IntPtr.Zero)
				id_readFrom_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "readFrom", "(Ljava/io/InputStream;)Lokio/Buffer;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Okio.Buffer __ret = global::Java.Lang.Object.GetObject<global::Okio.Buffer> (JNIEnv.CallObjectMethod  (Handle, id_readFrom_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_readFrom_Ljava_io_InputStream_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readFrom' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='long']]"
		[Register ("readFrom", "(Ljava/io/InputStream;J)Lokio/Buffer;", "")]
		public unsafe global::Okio.Buffer ReadFrom (global::System.IO.Stream p0, long p1)
		{
			if (id_readFrom_Ljava_io_InputStream_J == IntPtr.Zero)
				id_readFrom_Ljava_io_InputStream_J = JNIEnv.GetMethodID (class_ref, "readFrom", "(Ljava/io/InputStream;J)Lokio/Buffer;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Okio.Buffer __ret = global::Java.Lang.Object.GetObject<global::Okio.Buffer> (JNIEnv.CallObjectMethod  (Handle, id_readFrom_Ljava_io_InputStream_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_readFully_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readFully' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("readFully", "([B)V", "")]
		public unsafe void ReadFully (byte[] p0)
		{
			if (id_readFully_arrayB == IntPtr.Zero)
				id_readFully_arrayB = JNIEnv.GetMethodID (class_ref, "readFully", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_readFully_arrayB, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_readFully_Lokio_Buffer_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readFully' and count(parameter)=2 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long']]"
		[Register ("readFully", "(Lokio/Buffer;J)V", "")]
		public unsafe void ReadFully (global::Okio.Buffer p0, long p1)
		{
			if (id_readFully_Lokio_Buffer_J == IntPtr.Zero)
				id_readFully_Lokio_Buffer_J = JNIEnv.GetMethodID (class_ref, "readFully", "(Lokio/Buffer;J)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_readFully_Lokio_Buffer_J, __args);
			} finally {
			}
		}

		static IntPtr id_readHexadecimalUnsignedLong;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readHexadecimalUnsignedLong' and count(parameter)=0]"
		[Register ("readHexadecimalUnsignedLong", "()J", "")]
		public unsafe long ReadHexadecimalUnsignedLong ()
		{
			if (id_readHexadecimalUnsignedLong == IntPtr.Zero)
				id_readHexadecimalUnsignedLong = JNIEnv.GetMethodID (class_ref, "readHexadecimalUnsignedLong", "()J");
			try {
				return JNIEnv.CallLongMethod  (Handle, id_readHexadecimalUnsignedLong);
			} finally {
			}
		}

		static IntPtr id_readInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readInt' and count(parameter)=0]"
		[Register ("readInt", "()I", "")]
		public unsafe int ReadInt ()
		{
			if (id_readInt == IntPtr.Zero)
				id_readInt = JNIEnv.GetMethodID (class_ref, "readInt", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_readInt);
			} finally {
			}
		}

		static IntPtr id_readIntLe;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readIntLe' and count(parameter)=0]"
		[Register ("readIntLe", "()I", "")]
		public unsafe int ReadIntLe ()
		{
			if (id_readIntLe == IntPtr.Zero)
				id_readIntLe = JNIEnv.GetMethodID (class_ref, "readIntLe", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_readIntLe);
			} finally {
			}
		}

		static IntPtr id_readLong;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readLong' and count(parameter)=0]"
		[Register ("readLong", "()J", "")]
		public unsafe long ReadLong ()
		{
			if (id_readLong == IntPtr.Zero)
				id_readLong = JNIEnv.GetMethodID (class_ref, "readLong", "()J");
			try {
				return JNIEnv.CallLongMethod  (Handle, id_readLong);
			} finally {
			}
		}

		static IntPtr id_readLongLe;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readLongLe' and count(parameter)=0]"
		[Register ("readLongLe", "()J", "")]
		public unsafe long ReadLongLe ()
		{
			if (id_readLongLe == IntPtr.Zero)
				id_readLongLe = JNIEnv.GetMethodID (class_ref, "readLongLe", "()J");
			try {
				return JNIEnv.CallLongMethod  (Handle, id_readLongLe);
			} finally {
			}
		}

		static IntPtr id_readShort;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readShort' and count(parameter)=0]"
		[Register ("readShort", "()S", "")]
		public unsafe short ReadShort ()
		{
			if (id_readShort == IntPtr.Zero)
				id_readShort = JNIEnv.GetMethodID (class_ref, "readShort", "()S");
			try {
				return JNIEnv.CallShortMethod  (Handle, id_readShort);
			} finally {
			}
		}

		static IntPtr id_readShortLe;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readShortLe' and count(parameter)=0]"
		[Register ("readShortLe", "()S", "")]
		public unsafe short ReadShortLe ()
		{
			if (id_readShortLe == IntPtr.Zero)
				id_readShortLe = JNIEnv.GetMethodID (class_ref, "readShortLe", "()S");
			try {
				return JNIEnv.CallShortMethod  (Handle, id_readShortLe);
			} finally {
			}
		}

		static IntPtr id_readString_Ljava_nio_charset_Charset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readString' and count(parameter)=1 and parameter[1][@type='java.nio.charset.Charset']]"
		[Register ("readString", "(Ljava/nio/charset/Charset;)Ljava/lang/String;", "")]
		public unsafe string ReadString (global::Java.Nio.Charset.Charset p0)
		{
			if (id_readString_Ljava_nio_charset_Charset_ == IntPtr.Zero)
				id_readString_Ljava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "readString", "(Ljava/nio/charset/Charset;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_readString_Ljava_nio_charset_Charset_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readString_JLjava_nio_charset_Charset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readString' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register ("readString", "(JLjava/nio/charset/Charset;)Ljava/lang/String;", "")]
		public unsafe string ReadString (long p0, global::Java.Nio.Charset.Charset p1)
		{
			if (id_readString_JLjava_nio_charset_Charset_ == IntPtr.Zero)
				id_readString_JLjava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "readString", "(JLjava/nio/charset/Charset;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_readString_JLjava_nio_charset_Charset_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readUtf8;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readUtf8' and count(parameter)=0]"
		[Register ("readUtf8", "()Ljava/lang/String;", "")]
		public unsafe string ReadUtf8 ()
		{
			if (id_readUtf8 == IntPtr.Zero)
				id_readUtf8 = JNIEnv.GetMethodID (class_ref, "readUtf8", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_readUtf8), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_readUtf8_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readUtf8' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("readUtf8", "(J)Ljava/lang/String;", "")]
		public unsafe string ReadUtf8 (long p0)
		{
			if (id_readUtf8_J == IntPtr.Zero)
				id_readUtf8_J = JNIEnv.GetMethodID (class_ref, "readUtf8", "(J)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_readUtf8_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_readUtf8CodePoint;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readUtf8CodePoint' and count(parameter)=0]"
		[Register ("readUtf8CodePoint", "()I", "")]
		public unsafe int ReadUtf8CodePoint ()
		{
			if (id_readUtf8CodePoint == IntPtr.Zero)
				id_readUtf8CodePoint = JNIEnv.GetMethodID (class_ref, "readUtf8CodePoint", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_readUtf8CodePoint);
			} finally {
			}
		}

		static IntPtr id_readUtf8Line;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readUtf8Line' and count(parameter)=0]"
		[Register ("readUtf8Line", "()Ljava/lang/String;", "")]
		public unsafe string ReadUtf8Line ()
		{
			if (id_readUtf8Line == IntPtr.Zero)
				id_readUtf8Line = JNIEnv.GetMethodID (class_ref, "readUtf8Line", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_readUtf8Line), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_readUtf8LineStrict;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='readUtf8LineStrict' and count(parameter)=0]"
		[Register ("readUtf8LineStrict", "()Ljava/lang/String;", "")]
		public unsafe string ReadUtf8LineStrict ()
		{
			if (id_readUtf8LineStrict == IntPtr.Zero)
				id_readUtf8LineStrict = JNIEnv.GetMethodID (class_ref, "readUtf8LineStrict", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_readUtf8LineStrict), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_request_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='request' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("request", "(J)Z", "")]
		public unsafe bool Request (long p0)
		{
			if (id_request_J == IntPtr.Zero)
				id_request_J = JNIEnv.GetMethodID (class_ref, "request", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallBooleanMethod  (Handle, id_request_J, __args);
			} finally {
			}
		}

		static IntPtr id_require_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='require' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("require", "(J)V", "")]
		public unsafe void Require (long p0)
		{
			if (id_require_J == IntPtr.Zero)
				id_require_J = JNIEnv.GetMethodID (class_ref, "require", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_require_J, __args);
			} finally {
			}
		}

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()J", "")]
		public unsafe long Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()J");
			try {
				return JNIEnv.CallLongMethod  (Handle, id_size);
			} finally {
			}
		}

		static IntPtr id_skip_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("skip", "(J)V", "")]
		public unsafe void Skip (long p0)
		{
			if (id_skip_J == IntPtr.Zero)
				id_skip_J = JNIEnv.GetMethodID (class_ref, "skip", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_skip_J, __args);
			} finally {
			}
		}

		static IntPtr id_snapshot;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='snapshot' and count(parameter)=0]"
		[Register ("snapshot", "()Lokio/ByteString;", "")]
		public unsafe global::Okio.ByteString Snapshot ()
		{
			if (id_snapshot == IntPtr.Zero)
				id_snapshot = JNIEnv.GetMethodID (class_ref, "snapshot", "()Lokio/ByteString;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallObjectMethod  (Handle, id_snapshot), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_snapshot_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='snapshot' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("snapshot", "(I)Lokio/ByteString;", "")]
		public unsafe global::Okio.ByteString Snapshot (int p0)
		{
			if (id_snapshot_I == IntPtr.Zero)
				id_snapshot_I = JNIEnv.GetMethodID (class_ref, "snapshot", "(I)Lokio/ByteString;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString> (JNIEnv.CallObjectMethod  (Handle, id_snapshot_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_timeout;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='timeout' and count(parameter)=0]"
		[Register ("timeout", "()Lokio/Timeout;", "")]
		public unsafe global::Okio.Timeout Timeout ()
		{
			if (id_timeout == IntPtr.Zero)
				id_timeout = JNIEnv.GetMethodID (class_ref, "timeout", "()Lokio/Timeout;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (JNIEnv.CallObjectMethod  (Handle, id_timeout), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_write_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='write' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("write", "([B)Lokio/Buffer;", "")]
		public unsafe global::Okio.IBufferedSink Write (byte[] p0)
		{
			if (id_write_arrayB == IntPtr.Zero)
				id_write_arrayB = JNIEnv.GetMethodID (class_ref, "write", "([B)Lokio/Buffer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Okio.IBufferedSink __ret = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod  (Handle, id_write_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_write_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='write' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("write", "([BII)Lokio/Buffer;", "")]
		public unsafe global::Okio.IBufferedSink Write (byte[] p0, int p1, int p2)
		{
			if (id_write_arrayBII == IntPtr.Zero)
				id_write_arrayBII = JNIEnv.GetMethodID (class_ref, "write", "([BII)Lokio/Buffer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Okio.IBufferedSink __ret = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod  (Handle, id_write_arrayBII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_write_Lokio_Buffer_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='write' and count(parameter)=2 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long']]"
		[Register ("write", "(Lokio/Buffer;J)V", "")]
		public unsafe void Write (global::Okio.Buffer p0, long p1)
		{
			if (id_write_Lokio_Buffer_J == IntPtr.Zero)
				id_write_Lokio_Buffer_J = JNIEnv.GetMethodID (class_ref, "write", "(Lokio/Buffer;J)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_write_Lokio_Buffer_J, __args);
			} finally {
			}
		}

		static IntPtr id_write_Lokio_ByteString_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='write' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
		[Register ("write", "(Lokio/ByteString;)Lokio/Buffer;", "")]
		public unsafe global::Okio.IBufferedSink Write (global::Okio.ByteString p0)
		{
			if (id_write_Lokio_ByteString_ == IntPtr.Zero)
				id_write_Lokio_ByteString_ = JNIEnv.GetMethodID (class_ref, "write", "(Lokio/ByteString;)Lokio/Buffer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Okio.IBufferedSink __ret = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod  (Handle, id_write_Lokio_ByteString_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_write_Lokio_Source_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='write' and count(parameter)=2 and parameter[1][@type='okio.Source'] and parameter[2][@type='long']]"
		[Register ("write", "(Lokio/Source;J)Lokio/BufferedSink;", "")]
		public unsafe global::Okio.IBufferedSink Write (global::Okio.ISource p0, long p1)
		{
			if (id_write_Lokio_Source_J == IntPtr.Zero)
				id_write_Lokio_Source_J = JNIEnv.GetMethodID (class_ref, "write", "(Lokio/Source;J)Lokio/BufferedSink;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Okio.IBufferedSink __ret = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod  (Handle, id_write_Lokio_Source_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_writeAll_Lokio_Source_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeAll' and count(parameter)=1 and parameter[1][@type='okio.Source']]"
		[Register ("writeAll", "(Lokio/Source;)J", "")]
		public unsafe long WriteAll (global::Okio.ISource p0)
		{
			if (id_writeAll_Lokio_Source_ == IntPtr.Zero)
				id_writeAll_Lokio_Source_ = JNIEnv.GetMethodID (class_ref, "writeAll", "(Lokio/Source;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallLongMethod  (Handle, id_writeAll_Lokio_Source_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_writeByte_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeByte' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeByte", "(I)Lokio/Buffer;", "")]
		public unsafe global::Okio.IBufferedSink WriteByte (int p0)
		{
			if (id_writeByte_I == IntPtr.Zero)
				id_writeByte_I = JNIEnv.GetMethodID (class_ref, "writeByte", "(I)Lokio/Buffer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod  (Handle, id_writeByte_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_writeDecimalLong_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeDecimalLong' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeDecimalLong", "(J)Lokio/Buffer;", "")]
		public unsafe global::Okio.IBufferedSink WriteDecimalLong (long p0)
		{
			if (id_writeDecimalLong_J == IntPtr.Zero)
				id_writeDecimalLong_J = JNIEnv.GetMethodID (class_ref, "writeDecimalLong", "(J)Lokio/Buffer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod  (Handle, id_writeDecimalLong_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_writeHexadecimalUnsignedLong_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeHexadecimalUnsignedLong' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeHexadecimalUnsignedLong", "(J)Lokio/Buffer;", "")]
		public unsafe global::Okio.IBufferedSink WriteHexadecimalUnsignedLong (long p0)
		{
			if (id_writeHexadecimalUnsignedLong_J == IntPtr.Zero)
				id_writeHexadecimalUnsignedLong_J = JNIEnv.GetMethodID (class_ref, "writeHexadecimalUnsignedLong", "(J)Lokio/Buffer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod  (Handle, id_writeHexadecimalUnsignedLong_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_writeInt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeInt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeInt", "(I)Lokio/Buffer;", "")]
		public unsafe global::Okio.IBufferedSink WriteInt (int p0)
		{
			if (id_writeInt_I == IntPtr.Zero)
				id_writeInt_I = JNIEnv.GetMethodID (class_ref, "writeInt", "(I)Lokio/Buffer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod  (Handle, id_writeInt_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_writeIntLe_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeIntLe' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeIntLe", "(I)Lokio/Buffer;", "")]
		public unsafe global::Okio.IBufferedSink WriteIntLe (int p0)
		{
			if (id_writeIntLe_I == IntPtr.Zero)
				id_writeIntLe_I = JNIEnv.GetMethodID (class_ref, "writeIntLe", "(I)Lokio/Buffer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod  (Handle, id_writeIntLe_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_writeLong_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeLong' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeLong", "(J)Lokio/Buffer;", "")]
		public unsafe global::Okio.IBufferedSink WriteLong (long p0)
		{
			if (id_writeLong_J == IntPtr.Zero)
				id_writeLong_J = JNIEnv.GetMethodID (class_ref, "writeLong", "(J)Lokio/Buffer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod  (Handle, id_writeLong_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_writeLongLe_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeLongLe' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeLongLe", "(J)Lokio/Buffer;", "")]
		public unsafe global::Okio.IBufferedSink WriteLongLe (long p0)
		{
			if (id_writeLongLe_J == IntPtr.Zero)
				id_writeLongLe_J = JNIEnv.GetMethodID (class_ref, "writeLongLe", "(J)Lokio/Buffer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod  (Handle, id_writeLongLe_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_writeShort_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeShort' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeShort", "(I)Lokio/Buffer;", "")]
		public unsafe global::Okio.IBufferedSink WriteShort (int p0)
		{
			if (id_writeShort_I == IntPtr.Zero)
				id_writeShort_I = JNIEnv.GetMethodID (class_ref, "writeShort", "(I)Lokio/Buffer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod  (Handle, id_writeShort_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_writeShortLe_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeShortLe' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeShortLe", "(I)Lokio/Buffer;", "")]
		public unsafe global::Okio.IBufferedSink WriteShortLe (int p0)
		{
			if (id_writeShortLe_I == IntPtr.Zero)
				id_writeShortLe_I = JNIEnv.GetMethodID (class_ref, "writeShortLe", "(I)Lokio/Buffer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod  (Handle, id_writeShortLe_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_writeString_Ljava_lang_String_IILjava_nio_charset_Charset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeString' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.nio.charset.Charset']]"
		[Register ("writeString", "(Ljava/lang/String;IILjava/nio/charset/Charset;)Lokio/Buffer;", "")]
		public unsafe global::Okio.IBufferedSink WriteString (string p0, int p1, int p2, global::Java.Nio.Charset.Charset p3)
		{
			if (id_writeString_Ljava_lang_String_IILjava_nio_charset_Charset_ == IntPtr.Zero)
				id_writeString_Ljava_lang_String_IILjava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "writeString", "(Ljava/lang/String;IILjava/nio/charset/Charset;)Lokio/Buffer;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Okio.IBufferedSink __ret = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod  (Handle, id_writeString_Ljava_lang_String_IILjava_nio_charset_Charset_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_writeString_Ljava_lang_String_Ljava_nio_charset_Charset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register ("writeString", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Lokio/Buffer;", "")]
		public unsafe global::Okio.IBufferedSink WriteString (string p0, global::Java.Nio.Charset.Charset p1)
		{
			if (id_writeString_Ljava_lang_String_Ljava_nio_charset_Charset_ == IntPtr.Zero)
				id_writeString_Ljava_lang_String_Ljava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "writeString", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Lokio/Buffer;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Okio.IBufferedSink __ret = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod  (Handle, id_writeString_Ljava_lang_String_Ljava_nio_charset_Charset_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_writeTo_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("writeTo", "(Ljava/io/OutputStream;)Lokio/Buffer;", "")]
		public unsafe global::Okio.IBufferedSink WriteTo (global::System.IO.Stream p0)
		{
			if (id_writeTo_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_writeTo_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(Ljava/io/OutputStream;)Lokio/Buffer;");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Okio.IBufferedSink __ret = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod  (Handle, id_writeTo_Ljava_io_OutputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_writeTo_Ljava_io_OutputStream_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeTo' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='long']]"
		[Register ("writeTo", "(Ljava/io/OutputStream;J)Lokio/Buffer;", "")]
		public unsafe global::Okio.IBufferedSink WriteTo (global::System.IO.Stream p0, long p1)
		{
			if (id_writeTo_Ljava_io_OutputStream_J == IntPtr.Zero)
				id_writeTo_Ljava_io_OutputStream_J = JNIEnv.GetMethodID (class_ref, "writeTo", "(Ljava/io/OutputStream;J)Lokio/Buffer;");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Okio.IBufferedSink __ret = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod  (Handle, id_writeTo_Ljava_io_OutputStream_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_writeUtf8_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeUtf8' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("writeUtf8", "(Ljava/lang/String;)Lokio/Buffer;", "")]
		public unsafe global::Okio.IBufferedSink WriteUtf8 (string p0)
		{
			if (id_writeUtf8_Ljava_lang_String_ == IntPtr.Zero)
				id_writeUtf8_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writeUtf8", "(Ljava/lang/String;)Lokio/Buffer;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Okio.IBufferedSink __ret = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod  (Handle, id_writeUtf8_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_writeUtf8_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeUtf8' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("writeUtf8", "(Ljava/lang/String;II)Lokio/Buffer;", "")]
		public unsafe global::Okio.IBufferedSink WriteUtf8 (string p0, int p1, int p2)
		{
			if (id_writeUtf8_Ljava_lang_String_II == IntPtr.Zero)
				id_writeUtf8_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "writeUtf8", "(Ljava/lang/String;II)Lokio/Buffer;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Okio.IBufferedSink __ret = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod  (Handle, id_writeUtf8_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_writeUtf8CodePoint_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Buffer']/method[@name='writeUtf8CodePoint' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeUtf8CodePoint", "(I)Lokio/Buffer;", "")]
		public unsafe global::Okio.IBufferedSink WriteUtf8CodePoint (int p0)
		{
			if (id_writeUtf8CodePoint_I == IntPtr.Zero)
				id_writeUtf8CodePoint_I = JNIEnv.GetMethodID (class_ref, "writeUtf8CodePoint", "(I)Lokio/Buffer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallObjectMethod  (Handle, id_writeUtf8CodePoint_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
