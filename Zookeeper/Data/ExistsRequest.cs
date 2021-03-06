﻿using System;

namespace Sodao.Zookeeper.Data
{
    /// <summary>
    /// exists request
    /// </summary>
    public sealed class ExistsRequest : IRecord
    {
        /// <summary>
        /// path
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// true表示侦听
        /// </summary>
        public readonly bool Watch;

        /// <summary>
        /// new
        /// </summary>
        /// <param name="path"></param>
        /// <param name="watch"></param>
        public ExistsRequest(string path, bool watch)
        {
            this.Path = path;
            this.Watch = watch;
        }

        /// <summary>
        /// write
        /// </summary>
        /// <param name="formatter"></param>
        public void Write(Utils.IFormatter formatter)
        {
            formatter.Write(this.Path);
            formatter.Write(this.Watch);
        }
        /// <summary>
        /// read
        /// </summary>
        /// <param name="formatter"></param>
        public void Read(Utils.IFormatter formatter)
        {
            throw new NotImplementedException();
        }
    }
}