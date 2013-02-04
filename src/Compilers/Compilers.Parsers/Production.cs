﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBF.Compilers.Parsers.Generator;

namespace VBF.Compilers.Parsers
{
    public class Production<T> : ProductionBase<T>
    {
        public ProductionBase<T> Rule { get; set; }

        internal override ProductionInfo Info
        {
            get
            {
                return Rule.Info;
            }
            set
            {
                Rule.Info = value;
            }
        }

        public Production()
        {

        }

        public override void Accept(IProductionVisitor visitor)
        {
            Rule.Accept(visitor);
        }

        public override bool IsTerminal
        {
            get
            {
                return Rule.IsTerminal;
            }
        }

        public override bool IsEos
        {
            get
            {
                return Rule.IsEos;
            }
        }

        public override bool Equals(object obj)
        {
            return Rule.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Rule.GetHashCode();
        }

        public override string DebugName
        {
            get
            {
                return Rule.DebugName;
            }
        }

        public override string ToString()
        {
            return Rule.ToString();
        }
    }
}