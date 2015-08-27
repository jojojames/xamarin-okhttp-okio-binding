using System;

namespace Okio {
	partial class Buffer {

		Buffer IBufferedSink.Buffer () {
			return this;
		}

		Buffer IBufferedSource.Buffer () {
			return this;
		}
	}
}

