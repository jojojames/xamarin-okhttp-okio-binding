using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okio {

	// Metadata.xml XPath class reference: path="/api/package[@name='okio']/class[@name='Okio']"
	[global::Android.Runtime.Register ("okio/Okio", DoNotGenerateAcw=true)]
	public sealed partial class Okio : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okio/Okio", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Okio); }
		}

		internal Okio (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_appendingSink_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Okio']/method[@name='appendingSink' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("appendingSink", "(Ljava/io/File;)Lokio/Sink;", "")]
		public static unsafe global::Okio.ISink AppendingSink (global::Java.IO.File p0)
		{
			if (id_appendingSink_Ljava_io_File_ == IntPtr.Zero)
				id_appendingSink_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "appendingSink", "(Ljava/io/File;)Lokio/Sink;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Okio.ISink __ret = global::Java.Lang.Object.GetObject<global::Okio.ISink> (JNIEnv.CallStaticObjectMethod  (class_ref, id_appendingSink_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_buffer_Lokio_Sink_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Okio']/method[@name='buffer' and count(parameter)=1 and parameter[1][@type='okio.Sink']]"
		[Register ("buffer", "(Lokio/Sink;)Lokio/BufferedSink;", "")]
		public static unsafe global::Okio.IBufferedSink Buffer (global::Okio.ISink p0)
		{
			if (id_buffer_Lokio_Sink_ == IntPtr.Zero)
				id_buffer_Lokio_Sink_ = JNIEnv.GetStaticMethodID (class_ref, "buffer", "(Lokio/Sink;)Lokio/BufferedSink;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Okio.IBufferedSink __ret = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSink> (JNIEnv.CallStaticObjectMethod  (class_ref, id_buffer_Lokio_Sink_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_buffer_Lokio_Source_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Okio']/method[@name='buffer' and count(parameter)=1 and parameter[1][@type='okio.Source']]"
		[Register ("buffer", "(Lokio/Source;)Lokio/BufferedSource;", "")]
		public static unsafe global::Okio.IBufferedSource Buffer (global::Okio.ISource p0)
		{
			if (id_buffer_Lokio_Source_ == IntPtr.Zero)
				id_buffer_Lokio_Source_ = JNIEnv.GetStaticMethodID (class_ref, "buffer", "(Lokio/Source;)Lokio/BufferedSource;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Okio.IBufferedSource __ret = global::Java.Lang.Object.GetObject<global::Okio.IBufferedSource> (JNIEnv.CallStaticObjectMethod  (class_ref, id_buffer_Lokio_Source_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sink_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Okio']/method[@name='sink' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("sink", "(Ljava/io/File;)Lokio/Sink;", "")]
		public static unsafe global::Okio.ISink Sink (global::Java.IO.File p0)
		{
			if (id_sink_Ljava_io_File_ == IntPtr.Zero)
				id_sink_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "sink", "(Ljava/io/File;)Lokio/Sink;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Okio.ISink __ret = global::Java.Lang.Object.GetObject<global::Okio.ISink> (JNIEnv.CallStaticObjectMethod  (class_ref, id_sink_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sink_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Okio']/method[@name='sink' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("sink", "(Ljava/io/OutputStream;)Lokio/Sink;", "")]
		public static unsafe global::Okio.ISink Sink (global::System.IO.Stream p0)
		{
			if (id_sink_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_sink_Ljava_io_OutputStream_ = JNIEnv.GetStaticMethodID (class_ref, "sink", "(Ljava/io/OutputStream;)Lokio/Sink;");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Okio.ISink __ret = global::Java.Lang.Object.GetObject<global::Okio.ISink> (JNIEnv.CallStaticObjectMethod  (class_ref, id_sink_Ljava_io_OutputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_sink_Ljava_net_Socket_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Okio']/method[@name='sink' and count(parameter)=1 and parameter[1][@type='java.net.Socket']]"
		[Register ("sink", "(Ljava/net/Socket;)Lokio/Sink;", "")]
		public static unsafe global::Okio.ISink Sink (global::Java.Net.Socket p0)
		{
			if (id_sink_Ljava_net_Socket_ == IntPtr.Zero)
				id_sink_Ljava_net_Socket_ = JNIEnv.GetStaticMethodID (class_ref, "sink", "(Ljava/net/Socket;)Lokio/Sink;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Okio.ISink __ret = global::Java.Lang.Object.GetObject<global::Okio.ISink> (JNIEnv.CallStaticObjectMethod  (class_ref, id_sink_Ljava_net_Socket_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_source_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Okio']/method[@name='source' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("source", "(Ljava/io/File;)Lokio/Source;", "")]
		public static unsafe global::Okio.ISource Source (global::Java.IO.File p0)
		{
			if (id_source_Ljava_io_File_ == IntPtr.Zero)
				id_source_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "source", "(Ljava/io/File;)Lokio/Source;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Okio.ISource __ret = global::Java.Lang.Object.GetObject<global::Okio.ISource> (JNIEnv.CallStaticObjectMethod  (class_ref, id_source_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_source_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Okio']/method[@name='source' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("source", "(Ljava/io/InputStream;)Lokio/Source;", "")]
		public static unsafe global::Okio.ISource Source (global::System.IO.Stream p0)
		{
			if (id_source_Ljava_io_InputStream_ == IntPtr.Zero)
				id_source_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "source", "(Ljava/io/InputStream;)Lokio/Source;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Okio.ISource __ret = global::Java.Lang.Object.GetObject<global::Okio.ISource> (JNIEnv.CallStaticObjectMethod  (class_ref, id_source_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_source_Ljava_net_Socket_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Okio']/method[@name='source' and count(parameter)=1 and parameter[1][@type='java.net.Socket']]"
		[Register ("source", "(Ljava/net/Socket;)Lokio/Source;", "")]
		public static unsafe global::Okio.ISource Source (global::Java.Net.Socket p0)
		{
			if (id_source_Ljava_net_Socket_ == IntPtr.Zero)
				id_source_Ljava_net_Socket_ = JNIEnv.GetStaticMethodID (class_ref, "source", "(Ljava/net/Socket;)Lokio/Source;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Okio.ISource __ret = global::Java.Lang.Object.GetObject<global::Okio.ISource> (JNIEnv.CallStaticObjectMethod  (class_ref, id_source_Ljava_net_Socket_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
