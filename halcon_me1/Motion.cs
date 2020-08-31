using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using csLTDMC;

namespace halcon_me1
{
    public  class Motion
    {

        /// <summary>
        /// 控制卡ID
        /// </summary>
        private ushort _CardID = 0;

        /// <summary>
        /// 初始化控制卡
        /// </summary>
        /// <returns></returns>
        public bool InitMotionCard()
        {
            short num = LTDMC.dmc_board_init();//获取卡数量
            if (num <= 0 || num > 8)
            {
                return false;
            }

            ushort      _num        = 0;
            ushort[]    cardids     = new ushort[8];
            uint[]      cardtypes   = new uint[8];
            short res = LTDMC.dmc_get_CardInfList(ref _num, cardtypes, cardids);
            if (res != 0)
            {
                MessageBox.Show("获取卡信息失败!");
            }
            _CardID = cardids[0];

            return true;
        }

        /// <summary>
        /// 连续运动
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="start"></param>
        /// <param name="speed"></param>
        /// <param name="stop"></param>
        /// <param name="acc"></param>
        /// <param name="dec"></param>
        /// <param name="Direct"></param>
        public void ContinuationMove(ushort axis, double start, double speed, double stop, double acc, double dec, ushort Direct)
        {
            LTDMC.dmc_set_pulse_outmode(_CardID, axis, 0);                     //设置脉冲模式
            LTDMC.dmc_set_s_profile(_CardID, axis, 0, 0.01);                   //设置S段时间（0-0.05s)
            LTDMC.dmc_set_profile(_CardID, axis, start, speed, acc, dec, stop);//设置起始速度、运行速度、停止速度、加速时间、减速时间
            LTDMC.dmc_vmove(_CardID, axis, Direct);                            //连续运动

        }

        //减速停止
        public void DecelerateStop(ushort axis)
        {
            LTDMC.dmc_stop(_CardID, axis, 0);
        }

        /// <summary>
        /// 立即停止
        /// </summary>
        /// <param name="axis"></param>
        public void ImmediatelyStop(ushort axis)
        {
            LTDMC.dmc_stop(_CardID, axis, 1);
        }

        /// <summary>
        /// 读取指定端口信号
        /// </summary>
        /// <param name="Port"></param>
        public uint ReadInputPortByPort(ushort Port)
        {
            uint Level = LTDMC.dmc_read_inport(_CardID, Port);
            return Level;
        }

        /// <summary>
        /// 向指定输出端口写值
        /// </summary>
        /// <param name="Port"></param>
        /// <param name="PortValue"></param>
        public void WriteOutputByPort(ushort Port,ushort PortValue)
        {
            LTDMC.dmc_write_outbit(_CardID, Port, PortValue);
        }

        /// <summary>
        /// 读取所有IO端口信号
        /// </summary>
        /// <param name="PortRange"></param>
        /// <returns></returns>
        public UInt32 ReadInputPort(UInt16 PortRange)
        {
            UInt32 Level = LTDMC.dmc_read_inport(_CardID, PortRange);
            return Level;
        }

        /// <summary>
        /// 向所有输出端口写值
        /// </summary>
        /// <param name="PortRange"></param>
        /// <param name="PortValue"></param>
        public void WriteOutputPort(UInt16 PortRange, UInt32 PortValue)
        {
            LTDMC.dmc_write_outport(_CardID, PortRange, PortValue);
        }


        /// <summary>
        /// 关闭控制卡
        /// </summary>
        /// <returns></returns>
        public int CloseMotionCard()
        {
            int Flag=LTDMC.dmc_board_close();
            return Flag;
        }
    }
}
