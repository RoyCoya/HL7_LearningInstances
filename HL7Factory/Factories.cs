using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HL7Lib;

namespace HL7Factory
{
    /// <summary>
    /// 抽象工厂
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract AbstractType Create(CompositeType parent,Enum product,string name);
    }

    /// <summary>
    /// <para>消息工厂，根据消息类型创建对应消息类的实例</para>
    /// <para>取消息类型：MessageFactory.MessageType</para>
    /// </summary>
    public class MessageFactory : AbstractFactory
    {
        /// <summary>
        /// 消息类枚举
        /// </summary>
        public enum MessageType { ACK }
        /// <summary>
        /// 创建对应消息类的实例
        /// </summary>
        /// <param name="parent">父级</param>
        /// <param name="product">消息类，从MessageType（消息类枚举）中找</param>
        /// <param name="name">消息名称</param>
        /// <returns>对应消息类的消息实例</returns>
        public override AbstractType Create(CompositeType parent, Enum product, string name)
        {
            switch(product)
            {
                case MessageType.ACK:
                    return new ACK(null, name);
                default: throw new Exception("没有找到对应的消息类");
            }
        }
    }

    /// <summary>
    /// <para>段工厂，根据段父级对象、段名生成对应段实例</para>
    /// <para>取段类型：SegmentFactory.SegmentType</para>
    /// </summary>
    public class SegmentFactory : AbstractFactory
    {
        /// <summary>
        /// 段枚举
        /// </summary>
        public enum SegmentType { EVN, MSH, MSA, ERR }
        /// <summary>
        /// 创建对应段类的实例
        /// </summary>
        /// <param name="parent">父级</param>
        /// <param name="product">段类，SegmentType（段类枚举）中找</param>
        /// <param name="name">段名称</param>
        /// <returns>对应段类的段实例</returns>
        public override AbstractType Create(CompositeType parent, Enum product, string name)
        {
            switch (product)
            {
                case SegmentType.EVN:
                    return new EVN((Message)parent, name);
                case SegmentType.MSH:
                    return new MSH((Message)parent, name);
                case SegmentType.MSA:
                    return new EVN((Message)parent, name);
                case SegmentType.ERR:
                    return new EVN((Message)parent, name);
                default: throw new Exception("没有找到对应的段类");
            }
        }
    }

    /// <summary>
    /// <para>字段工厂，根据段父级对象、字段名生成对应段实例</para>
    /// <para>取复杂字段类型：FieldFactory.CompositeField</para>
    /// <para>取简单字段类型：FieldFactory.factory.PrimitiveField（这两部分代码可优化）</para>
    /// </summary>
    public class FieldFactory : AbstractFactory
    {
        /// <summary>
        /// 默认的简单字段工厂
        /// </summary>
        public PrimitiveFieldFactory factory;
        /// <summary>
        /// 复杂字段类枚举
        /// </summary>
        public enum CompositeField { CE, EI, HD, MSG, PT, VID }
        /// <summary>
        /// 创建对应字段类的实例
        /// </summary>
        /// <param name="parent">父级</param>
        /// <param name="product">字段类，CompositeField和factory.PrimitiveField中找</param>
        /// <param name="name">字段名称</param>
        /// <returns>对应字段类的段实例</returns>
        public override AbstractType Create(CompositeType parent, Enum product, string name)
        {
            switch (product)
            {
                case CompositeField.CE:
                    return new CE((Segment)parent, name);
                case CompositeField.EI:
                    return new EI((Segment)parent, name);
                case CompositeField.HD:
                    return new HD((Segment)parent, name);
                case CompositeField.MSG:
                    return new MSG((Segment)parent, name);
                case CompositeField.PT:
                    return new PT((Segment)parent, name);
                case CompositeField.VID:
                    return new VID((Segment)parent, name);
                default:
                    return factory.Create(parent,product,name);
            }
        }
    }

    /// <summary>
    /// 简单字段类，由字段工厂FieldFactory调用
    /// </summary>
    public class PrimitiveFieldFactory : AbstractFactory
    {
        public enum PrimitiveField { DT, FT, ID, IS, NM, SI, ST, TM, TN, TS, TX }
        public override AbstractType Create(CompositeType parent, Enum product, string name)
        {
            switch (product)
            {
                case PrimitiveField.DT:
                    return new DT(name);
                case PrimitiveField.FT:
                    return new FT(name);
                case PrimitiveField.ID:
                    return new ID(name);
                case PrimitiveField.IS:
                    return new IS(name);
                case PrimitiveField.NM:
                    return new NM(name);
                case PrimitiveField.SI:
                    return new SI(name);
                case PrimitiveField.ST:
                    return new ST(name);
                case PrimitiveField.TM:
                    return new TM(name);
                case PrimitiveField.TN:
                    return new TN(name);
                case PrimitiveField.TS:
                    return new TS(name);
                case PrimitiveField.TX:
                    return new TX(name);
                default: throw new Exception("没有找到对应的字段类");
            }
        }
    }
}
