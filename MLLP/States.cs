using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static MLLP.Context;

namespace MLLP
{
    public abstract class States
    {
        public abstract void Handle(Context ctx, byte ch);
    }

    public class WaitState : States
    {
        public override void Handle(Context ctx, byte ch)
        {
            switch (ch)
            {
                case (byte)EnumEvent.SB:
                    ctx.InitBuff();
                    ctx.ChangeState(EnumState.DATA);
                    break;
                default:
                    break;
            }
        }
    }

    public class DataState : States
    {
        public override void Handle(Context ctx, byte ch)
        {
            switch (ch)
            {
                case (byte)EnumEvent.EB:
                    ctx.ChangeState(EnumState.END);
                    break;
                case (byte)EnumEvent.SB:
                    ctx.InitBuff();
                    break;
                case (byte)EnumEvent.CR:
                    ctx.BufferIn(ch);
                    break;
                default:
                    ctx.BufferIn(ch);
                    break;
            }
        }
    }

    public class EndState : States
    {
        public override void Handle(Context ctx, byte ch)
        {
            switch (ch)
            {
                case (byte)EnumEvent.EB:
                    ctx.ChangeState(EnumState.WAIT);
                    break;
                case (byte)EnumEvent.SB:
                    ctx.ChangeState(EnumState.DATA);
                    ctx.InitBuff();
                    break;
                case (byte)EnumEvent.CR:
                    ctx.MsgProc();
                    break;
                default:
                    ctx.ChangeState(EnumState.WAIT);
                    break;
            }
        }
    }
}