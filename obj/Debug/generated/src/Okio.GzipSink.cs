using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='GzipSink']"
	[global::Android.Runtime.Register ("okio/GzipSink", DoNotGenerateAcw=true)]
	public sealed partial class GzipSink : global::Java.Lang.Object, global::Okio.ISink {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okio/GzipSink", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GzipSink); }
		}

		internal GzipSink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lokio_Sink_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okio']/class[@name='GzipSink']/constructor[@name='GzipSink' and count(parameter)=1 and parameter[1][@type='okio.Sink']]"
		[Register (".ctor", "(Lokio/Sink;)V", "")]
		public unsafe GzipSink (global::Okio.ISink p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (GzipSink)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lokio/Sink;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lokio/Sink;)V", __args);
					return;
				}

				if (id_ctor_Lokio_Sink_ == IntPtr.Zero)
					id_ctor_Lokio_Sink_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lokio/Sink;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lokio_Sink_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lokio_Sink_, __args);
			} finally {
			}
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='GzipSink']/method[@name='close' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='GzipSink']/method[@name='flush' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='GzipSink']/method[@name='timeout' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='GzipSink']/method[@name='write' and count(parameter)=2 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long']]"
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
