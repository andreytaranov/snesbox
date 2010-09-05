﻿using System;

namespace Snes.DSP
{
    partial class DSP : Processor
    {
        public static readonly bool Threaded = true;
        public void step(uint clocks) { throw new NotImplementedException(); }
        public void synchronize_smp() { throw new NotImplementedException(); }

        public byte read(byte addr) { throw new NotImplementedException(); }
        public void write(byte addr, byte data) { throw new NotImplementedException(); }

        public void enter() { throw new NotImplementedException(); }
        public void power() { throw new NotImplementedException(); }
        public void reset() { throw new NotImplementedException(); }

        public DSP() { throw new NotImplementedException(); }

        private enum global_reg_t
        {
            r_mvoll = 0x0c, r_mvolr = 0x1c,
            r_evoll = 0x2c, r_evolr = 0x3c,
            r_kon = 0x4c, r_koff = 0x5c,
            r_flg = 0x6c, r_endx = 0x7c,
            r_efb = 0x0d, r_pmon = 0x2d,
            r_non = 0x3d, r_eon = 0x4d,
            r_dir = 0x5d, r_esa = 0x6d,
            r_edl = 0x7d, r_fir = 0x0f,  //8 coefficients at 0x0f, 0x1f, ... 0x7f
        };

        //voice registers
        private enum voice_reg_t
        {
            v_voll = 0x00, v_volr = 0x01,
            v_pitchl = 0x02, v_pitchh = 0x03,
            v_srcn = 0x04, v_adsr0 = 0x05,
            v_adsr1 = 0x06, v_gain = 0x07,
            v_envx = 0x08, v_outx = 0x09,
        };

        //internal envelope modes
        private enum env_mode_t { env_release, env_attack, env_decay, env_sustain };

        //internal constants
        private static readonly int echo_hist_size = 8;
        private static readonly int brr_buf_size = 12;
        private static readonly int brr_block_size = 9;

        private state_t state;

        //voice state
        private voice_t[] voice = new voice_t[8];

        //gaussian
        private static readonly short[] gaussian_table = new short[512];
        private int gaussian_interpolate(voice_t v) { throw new NotImplementedException(); }

        //counter
        private static readonly int counter_range = 2048 * 5 * 3; //30720 (0x7800)
        private static readonly ushort[] counter_rate = new ushort[32];
        private static readonly ushort[] counter_offset = new ushort[32];
        private void counter_tick() { throw new NotImplementedException(); }
        private bool counter_poll(uint rate) { throw new NotImplementedException(); }

        //envelope
        private void envelope_run(voice_t v) { throw new NotImplementedException(); }

        //brr
        private void brr_decode(voice_t v) { throw new NotImplementedException(); }

        //misc
        private void misc_27() { throw new NotImplementedException(); }
        private void misc_28() { throw new NotImplementedException(); }
        private void misc_29() { throw new NotImplementedException(); }
        private void misc_30() { throw new NotImplementedException(); }

        //voice
        private void voice_output(voice_t v, bool channel) { throw new NotImplementedException(); }
        private void voice_1(voice_t v) { throw new NotImplementedException(); }
        private void voice_2(voice_t v) { throw new NotImplementedException(); }
        private void voice_3(voice_t v) { throw new NotImplementedException(); }
        private void voice_3a(voice_t v) { throw new NotImplementedException(); }
        private void voice_3b(voice_t v) { throw new NotImplementedException(); }
        private void voice_3c(voice_t v) { throw new NotImplementedException(); }
        private void voice_4(voice_t v) { throw new NotImplementedException(); }
        private void voice_5(voice_t v) { throw new NotImplementedException(); }
        private void voice_6(voice_t v) { throw new NotImplementedException(); }
        private void voice_7(voice_t v) { throw new NotImplementedException(); }
        private void voice_8(voice_t v) { throw new NotImplementedException(); }
        private void voice_9(voice_t v) { throw new NotImplementedException(); }

        //echo
        private int calc_fir(int i, bool channel) { throw new NotImplementedException(); }
        private int echo_output(bool channel) { throw new NotImplementedException(); }
        private void echo_read(bool channel) { throw new NotImplementedException(); }
        private void echo_write(bool channel) { throw new NotImplementedException(); }
        private void echo_22() { throw new NotImplementedException(); }
        private void echo_23() { throw new NotImplementedException(); }
        private void echo_24() { throw new NotImplementedException(); }
        private void echo_25() { throw new NotImplementedException(); }
        private void echo_26() { throw new NotImplementedException(); }
        private void echo_27() { throw new NotImplementedException(); }
        private void echo_28() { throw new NotImplementedException(); }
        private void echo_29() { throw new NotImplementedException(); }
        private void echo_30() { throw new NotImplementedException(); }

        //dsp
        private static void Enter() { throw new NotImplementedException(); }
        private void tick() { throw new NotImplementedException(); }
    }
}
