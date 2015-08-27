using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='GzipSource']"
	[global::Android.Runtime.Register ("okio/GzipSource", DoNotGenerateAcw=true)]
	public sealed partial class GzipSource : global::Java.Lang.Object, global::Okio.ISource {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okio/GzipSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GzipSource); }
		}

		internal GzipSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lokio_Source_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okio']/class[@name='GzipSource']/constructor[@name='GzipSource' and count(parameter)=1 and parameter[1][@type='okio.Source']]"
		[Register (".ctor", "(Lokio/Source;)V", "")]
		public unsafe GzipSource (global::Okio.ISource p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (GzipSource)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lokio/Source;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lokio/Source;)V", __args);
					return;
				}

				if (id_ctor_Lokio_Source_ == IntPtr.Zero)
					id_ctor_Lokio_Source_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lokio/Source;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lokio_Source_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lokio_Source_, __args);
			} finally {
			}
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='GzipSource']/method[@name='close' and count(parameter)=0]"
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

		static IntPtr id_read_Lokio_Buffer_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='GzipSource']/method[@name='read' and count(parameter)=2 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long']]"
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

		static IntPtr id_timeout;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='GzipSource']/method[@name='timeout' and count(parameter)=0]"
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

	}
}
