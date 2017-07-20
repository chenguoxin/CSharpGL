﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpGL
{
    /// <summary>
    /// glTexParameterf();
    /// </summary>
    public class TexParameterf : TexParameter
    {
        /// <summary>
        /// 
        /// </summary>
        public float PValue { get; set; }

        public TexParameterf(TextureTarget target, uint pname, string pnameString, float pValue)
            : base(target, pname, pnameString)
        {
            this.PValue = pValue;
        }

        public override void Apply()
        {
            GL.Instance.TexParameterf((uint)Target, PName, PValue);
        }

        public override string ToString()
        {
            return string.Format("glTexParameterf({0}, {1}, {2});", this.Target, this.PNameString, this.PValue);
        }
    }
}