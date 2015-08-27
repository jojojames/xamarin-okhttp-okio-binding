using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='DeflaterSink']"
	[global::Android.Runtime.Register ("okio/DeflaterSink", DoNotGenerateAcw=true)]
	public sealed partial class DeflaterSink : global::Java.Lang.Object, global::Okio.ISink {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okio/DeflaterSink", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeflaterSink); }
		}

		internal DeflaterSink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lokio_Sink_Ljava_util_zip_Deflater_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okio']/class[@name='DeflaterSink']/constructor[@name='DeflaterSink' and count(parameter)=2 and parameter[1][@type='okio.Sink'] and parameter[2][@type='java.util.zip.Deflater']]"
		[Register (".ctor", "(Lokio/Sink;Ljava/util/zip/Deflater;)V", "")]
		public unsafe DeflaterSink (global::Okio.ISink p0, global::Java.Util.Zip.Deflater p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (DeflaterSink)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lokio/Sink;Ljava/util/zip/Deflater;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lokio/Sink;Ljava/util/zip/Deflater;)V", __args);
					return;
				}

				if (id_ctor_Lokio_Sink_Ljava_util_zip_Deflater_ == IntPtr.Zero)
					id_ctor_Lokio_Sink_Ljava_util_zip_Deflater_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lokio/Sink;Ljava/util/zip/Deflater;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lokio_Sink_Ljava_util_zip_Deflater_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lokio_Sink_Ljava_util_zip_Deflater_, __args);
			} finally {
			}
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='DeflaterSink']/method[@name='close' and count(parameter)=0]"
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

		static IntPtr id_flush;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='DeflaterSink']/method[@name='flush' and count(parameter)=0]"
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

		static IntPtr id_timeout;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='DeflaterSink']/method[@name='timeout' and count(parameter)=0]"
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

		static IntPtr id_write_Lokio_Buffer_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='DeflaterSink']/method[@name='write' and count(parameter)=2 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long']]"
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

	}
}
