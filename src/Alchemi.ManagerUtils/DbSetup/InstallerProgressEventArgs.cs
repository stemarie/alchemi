#region Alchemi copyright and license notice

/*
* Alchemi [.NET Grid Computing Framework]
* http://www.alchemi.net
* Title         :  InstallerProgressEvent.cs
* Project       :  Alchemi.ManagerUtils.DbSetup
* Created on    :  19 January 2005
* Copyright     :  Copyright � 2005 The University of Melbourne
*                    This technology has been developed with the support of
*                    the Australian Research Council and the University of Melbourne
*                    research grants as part of the Gridbus Project
*                    within GRIDS Laboratory at the University of Melbourne, Australia.
* Author        :  Tibor Biro (tb@tbiro.com)
* License       :  GPL
*                    This program is free software; you can redistribute it and/or
*                    modify it under the terms of the GNU General Public
*                    License as published by the Free Software Foundation;
*                    See the GNU General Public License
*                    (http://www.gnu.org/copyleft/gpl.html) for more 
details.
*
*/
#endregion

using System;

namespace Alchemi.ManagerUtils.DbSetup
{
	/// <summary>
	/// Date used to send the installer progress information from the worker thread to the UI thread.
	/// </summary>
	public class InstallerProgressEventArgs : EventArgs
	{
        public InstallerProgressEventArgs(string message, int percentDone)
		{
			this.Message = message;
			this.PercentDone = percentDone;
		}


        #region Property - Message
        private string _Message;
        /// <summary>
        /// The message to add to the bottom of the log.
        /// </summary>
        public string Message
        {
            get { return _Message; }
            private set { _Message = value; }
        } 
        #endregion


        #region Property - PercentDone
        private int _PercentDone;
        /// <summary>
        /// The percentage completed
        /// </summary>
        public int PercentDone
        {
            get { return _PercentDone; }
            set { _PercentDone = value; }
        } 
        #endregion
	}
}
