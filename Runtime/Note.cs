using System;
using System.Collections.Generic;
using UnityEngine;

namespace Extendo
{
	[AddComponentMenu("Extendo/Note")]
	public class Note : MonoBehaviour
	{
		[TextArea(minLines: 3, maxLines: 8)]
		public string text;
		public List<Task> tasks = new ();
		public string     url;

		[Serializable]
		public class Task
		{
			[TextArea(minLines: 2, maxLines: 6)]
			public string name;
			public bool done;
		}

		[ContextMenu("Remove Completed Tasks")]
		private void RemoveCompletedTasks()
		{
			tasks.RemoveAll(task => task.done);
		}
	}
}