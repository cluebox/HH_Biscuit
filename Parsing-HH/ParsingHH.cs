using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpssLib.SpssDataset;
using SpssLib.DataReader;
using System.IO;


namespace Parsing_HH
{ 
    class ParsingHH
    {
        static void Main(string[] args)
        {
            int SURVEY_ID = 600447;
            string SURVEY_PERIOD = "2018-12-31";//survey period
            string country = "INDONESIA";//survey country
            DB_insertionHH iobj = new DB_insertionHH();
            string questions = "iobs,weight,r1,r2,r3,r4,r5,r7,r8,r9,r10,r11,r12,r172a,r172b,r173,r13,r14,r15,r16,r17,r18r,r19r,r20,r21r,r22,r121a,r121b,r121c,r121d,r121e,r122a,r122b,r25,r123a,r123b,r156a,r156b,r147r1,r147r2,r27a,r27b,r27c,r28,r124a,r124b,r124c,r124d,r124e,r125a,r125b,r31,r126a,r126b,r33a,r33b,r33c,r34,r127a,r127b,r127c,r127d,r127e,r128a,r128b,r37,r129a,r129b,r39a,r39b,r39c,r120,r40,r144a,r144b,r144c,r144d,r144e,r145a,r145b,r41,r42a,r43,r45,r47,r48,r50,r51,r52,r53,r54,r42b,r55,r57,r59,r60,r62,r63,r64,r65,r66,r42c,r67,r69,r71,r72,r74,r75,r76,r77,r78,r148,r149,r150,r79,r80,r81a,r81b,r82,r83a,r83b,r84,r146r1,r146r2,r146r3,r146r4,r146r5,r146r6,r146r7,r146r8,r146r9,r146r10,r146r11,r146r12,r146r13,r146r14,r146r15,r146r16,r146r17,r146r18,r146r19,r146r20,r146r21,r146r22,r146r23,r146r24,r146xr1,r146xr2,r146xr3,r146xr4,r146xr5,r146xr6,r146xr7,r146xr8,r146xr9,r146xr10,r146xr11,r146xr12,r146xr13,r146xr14,r146xr15,r146xr16,r146xr17,r146xr18,r146xr19,r146xr20,r146xr21,r146xr22,r146xr23,r146xr24,r146xr25,r146xr26,r146xr27,r146xr28,r146xr29,r146xr30,r146xr31,r146xr32,r146yr1,r146yr2,r146yr3,r146yr4,r146yr5,r146yr6,r146yr7,r146yr8,r146yr9,r146yr10,r146yr11,r146yr12,r146yr13,r146yr14,r146yr15,r146yr16,r146yr17,r146yr18,r146yr19,r146yr20,r146yr21,r146yr22,r146yr23,r146yr24,r146yr25,r146yr26,r146yr27,r146yr28,r146yr29,r146yr30,r146yr31,r146yr32,r137r1,r137r2,r137r3,r137r4,r137r5,r137r6,r137r7,r137r8,r137r9,r137r10,r137r11,r137xr1,r137xr2,r137xr3,r137xr4,r137xr5,r137xr6,r137xr7,r137xr8,r137xr9,r137xr10,r137xr11,r138r1,r138r2,r138r3,r138r4,r138r5,r138r6,r138r7,r131,r132,r133,r134,r135,r136,r239,r240,r241,r242,r243,hhbiadspont,hhwfbrspont,hhwfadspont,hhnobrspont,hhnoadspont,hhbibrspont,r146r1_1,r146r1_2,r146r1_3,r146r1_4,r146r1_5,r146r1_6,r146r1_7,r146r1_8,r146r2_1,r146r2_2,r146r2_3,r146r2_4,r146r2_5,r146r2_6,r146r2_7,r146r2_8,r146r3_1,r146r3_2,r146r3_3,r146r3_4,r146r3_5,r146r3_6,r146r3_7,r146r3_8,r146r4_1,r146r4_2,r146r4_3,r146r4_4,r146r4_5,r146r4_6,r146r4_7,r146r4_8,r146r5_1,r146r5_2,r146r5_3,r146r5_4,r146r5_5,r146r5_6,r146r5_7,r146r5_8,r146r6_1,r146r6_2,r146r6_3,r146r6_4,r146r6_5,r146r6_6,r146r6_7,r146r6_8,r146r7_1,r146r7_2,r146r7_3,r146r7_4,r146r7_5,r146r7_6,r146r7_7,r146r7_8,r146r8_1,r146r8_2,r146r8_3,r146r8_4,r146r8_5,r146r8_6,r146r8_7,r146r8_8,r146r9_1,r146r9_2,r146r9_3,r146r9_4,r146r9_5,r146r9_6,r146r9_7,r146r9_8,r146r10_1,r146r10_2,r146r10_3,r146r10_4,r146r10_5,r146r10_6,r146r10_7,r146r10_8,r146r11_1,r146r11_2,r146r11_3,r146r11_4,r146r11_5,r146r11_6,r146r11_7,r146r11_8,r146r12_1,r146r12_2,r146r12_3,r146r12_4,r146r12_5,r146r12_6,r146r12_7,r146r12_8,r146r13_1,r146r13_2,r146r13_3,r146r13_4,r146r13_5,r146r13_6,r146r13_7,r146r13_8,r146r14_1,r146r14_2,r146r14_3,r146r14_4,r146r14_5,r146r14_6,r146r14_7,r146r14_8,r146r15_1,r146r15_2,r146r15_3,r146r15_4,r146r15_5,r146r15_6,r146r15_7,r146r15_8,r146r16_1,r146r16_2,r146r16_3,r146r16_4,r146r16_5,r146r16_6,r146r16_7,r146r16_8,r146r17_1,r146r17_2,r146r17_3,r146r17_4,r146r17_5,r146r17_6,r146r17_7,r146r17_8,r146r18_1,r146r18_2,r146r18_3,r146r18_4,r146r18_5,r146r18_6,r146r18_7,r146r18_8,r146r19_1,r146r19_2,r146r19_3,r146r19_4,r146r19_5,r146r19_6,r146r19_7,r146r19_8,r146r20_1,r146r20_2,r146r20_3,r146r20_4,r146r20_5,r146r20_6,r146r20_7,r146r20_8,r146r21_1,r146r21_2,r146r21_3,r146r21_4,r146r21_5,r146r21_6,r146r21_7,r146r21_8,r146r22_1,r146r22_2,r146r22_3,r146r22_4,r146r22_5,r146r22_6,r146r22_7,r146r22_8,r146r23_1,r146r23_2,r146r23_3,r146r23_4,r146r23_5,r146r23_6,r146r23_7,r146r23_8,r146r24_1,r146r24_2,r146r24_3,r146r24_4,r146r24_5,r146r24_6,r146r24_7,r146r24_8,r146xr25_1,r146xr25_2,r146xr25_3,r146xr25_4,r146xr25_5,r146xr25_6,r146xr25_7,r146xr25_8,r146xr26_1,r146xr26_2,r146xr26_3,r146xr26_4,r146xr26_5,r146xr26_6,r146xr26_7,r146xr26_8,r146xr27_1,r146xr27_2,r146xr27_3,r146xr27_4,r146xr27_5,r146xr27_6,r146xr27_7,r146xr27_8,r146xr28_1,r146xr28_2,r146xr28_3,r146xr28_4,r146xr28_5,r146xr28_6,r146xr28_7,r146xr28_8,r146xr29_1,r146xr29_2,r146xr29_3,r146xr29_4,r146xr29_5,r146xr29_6,r146xr29_7,r146xr29_8,r146xr30_1,r146xr30_2,r146xr30_3,r146xr30_4,r146xr30_5,r146xr30_6,r146xr30_7,r146xr30_8,r138r1_1,r138r1_2,r138r1_3,r138r2_1,r138r2_2,r138r2_3,r138r3_1,r138r3_2,r138r3_3,r138r4_1,r138r4_2,r138r4_3,r138r5_1,r138r5_2,r138r5_3,r138r6_1,r138r6_2,r138r6_3,r138r7_1,r138r7_2,r138r7_3,r146zr1_1,r146zr1_2,r146zr1_3,r146zr1_4,r146zr1_5,r146zr1_6,r146zr1_7,r146zr1_8,r146zr2_1,r146zr2_2,r146zr2_3,r146zr2_4,r146zr2_5,r146zr2_6,r146zr2_7,r146zr2_8,r146zr3_1,r146zr3_2,r146zr3_3,r146zr3_4,r146zr3_5,r146zr3_6,r146zr3_7,r146zr3_8,r146zr4_1,r146zr4_2,r146zr4_3,r146zr4_4,r146zr4_5,r146zr4_6,r146zr4_7,r146zr4_8,r146zr5_1,r146zr5_2,r146zr5_3,r146zr5_4,r146zr5_5,r146zr5_6,r146zr5_7,r146zr5_8,r146zr6_1,r146zr6_2,r146zr6_3,r146zr6_4,r146zr6_5,r146zr6_6,r146zr6_7,r146zr6_8,r146zr7_1,r146zr7_2,r146zr7_3,r146zr7_4,r146zr7_5,r146zr7_6,r146zr7_7,r146zr7_8,r146zr8_1,r146zr8_2,r146zr8_3,r146zr8_4,r146zr8_5,r146zr8_6,r146zr8_7,r146zr8_8,r146zr9_1,r146zr9_2,r146zr9_3,r146zr9_4,r146zr9_5,r146zr9_6,r146zr9_7,r146zr9_8,r146zr10_1,r146zr10_2,r146zr10_3,r146zr10_4,r146zr10_5,r146zr10_6,r146zr10_7,r146zr10_8,r146zr11_1,r146zr11_2,r146zr11_3,r146zr11_4,r146zr11_5,r146zr11_6,r146zr11_7,r146zr11_8,r146zr12_1,r146zr12_2,r146zr12_3,r146zr12_4,r146zr12_5,r146zr12_6,r146zr12_7,r146zr12_8,r146zr13_1,r146zr13_2,r146zr13_3,r146zr13_4,r146zr13_5,r146zr13_6,r146zr13_7,r146zr13_8,r146zr14_1,r146zr14_2,r146zr14_3,r146zr14_4,r146zr14_5,r146zr14_6,r146zr14_7,r146zr14_8,r146zr15_1,r146zr15_2,r146zr15_3,r146zr15_4,r146zr15_5,r146zr15_6,r146zr15_7,r146zr15_8,r146zr16_1,r146zr16_2,r146zr16_3,r146zr16_4,r146zr16_5,r146zr16_6,r146zr16_7,r146zr16_8,r146zr18_1,r146zr18_2,r146zr18_3,r146zr18_4,r146zr18_5,r146zr18_6,r146zr18_7,r146zr18_8,r146zr19_1,r146zr19_2,r146zr19_3,r146zr19_4,r146zr19_5,r146zr19_6,r146zr19_7,r146zr19_8,r146zr21_1,r146zr21_2,r146zr21_3,r146zr21_4,r146zr21_5,r146zr21_6,r146zr21_7,r146zr21_8,r146zr22_1,r146zr22_2,r146zr22_3,r146zr22_4,r146zr22_5,r146zr22_6,r146zr22_7,r146zr22_8,r146zr25_1,r146zr25_2,r146zr25_3,r146zr25_4,r146zr25_5,r146zr25_6,r146zr25_7,r146zr25_8,r146zr26_1,r146zr26_2,r146zr26_3,r146zr26_4,r146zr26_5,r146zr26_6,r146zr26_7,r146zr26_8,r146zr27_1,r146zr27_2,r146zr27_3,r146zr27_4,r146zr27_5,r146zr27_6,r146zr27_7,r146zr27_8,r146zr28_1,r146zr28_2,r146zr28_3,r146zr28_4,r146zr28_5,r146zr28_6,r146zr28_7,r146zr28_8,r146zr29_1,r146zr29_2,r146zr29_3,r146zr29_4,r146zr29_5,r146zr29_6,r146zr29_7,r146zr29_8,r146zr30_1,r146zr30_2,r146zr30_3,r146zr30_4,r146zr30_5,r146zr30_6,r146zr30_7,r146zr30_8,r146zr17_1,r146zr17_2,r146zr17_3,r146zr17_4,r146zr17_5,r146zr17_6,r146zr17_7,r146zr17_8,r146zr20_1,r146zr20_2,r146zr20_3,r146zr20_4,r146zr20_5,r146zr20_6,r146zr20_7,r146zr20_8,r146zr23_1,r146zr23_2,r146zr23_3,r146zr23_4,r146zr23_5,r146zr23_6,r146zr23_7,r146zr23_8,r146zr24_1,r146zr24_2,r146zr24_3,r146zr24_4,r146zr24_5,r146zr24_6,r146zr24_7,r146zr24_8,r137xr1_1,r137xr1_2,r137xr1_3,r137xr1_4,r137xr3_1,r137xr3_2,r137xr3_3,r137xr3_4,r137xr4_1,r137xr4_2,r137xr4_3,r137xr4_4,r137xr5_1,r137xr5_2,r137xr5_3,r137xr5_4,r137xr6_1,r137xr6_2,r137xr6_3,r137xr6_4,r137xr7_1,r137xr7_2,r137xr7_3,r137xr7_4,r137xr8_1,r137xr8_2,r137xr8_3,r137xr8_4,r137xr9_1,r137xr9_2,r137xr9_3,r137xr9_4,r137xr11_1,r137xr11_2,r137xr11_3,r137xr11_4,r146zr33_1,r146zr33_2,r146zr33_3,r146zr33_4,r146zr33_5,r146zr33_6,r146zr33_7,r146zr33_8,r146zr34_1,r146zr34_2,r146zr34_3,r146zr34_4,r146zr34_5,r146zr34_6,r146zr34_7,r146zr34_8,r121ax,r121bx,r121cx,r121dx,r121ex,r123ax,r123bx,r27ax,r27bx,r27cx,r124ax,r124bx,r124cx,r124dx,r124ex,r126ax,r126bx,r33ax,r33bx,r33cx,hhnetbrspont,hhnetadspont,wfnetbrspont,wfnetadspont,r185,r181a,q146ft1_14,q146ft1_15,q146ft1_16,q146ft1_18,q146ft1_19,q146ft1_4,q146ft1_5,q146ft6_8,q146ft6_9,q146ft6_11,q146ft6_12,q146ft6_13,q146ft6_14,q146ft2_2,q146ft2_4,q146ft2_5,q146ft2_8,q146ft2_11,q146ft2_13,q146ft2_14,q146ft2_18,q146ft2_19,q146ft7_2,q146ft7_4,q146ft7_5,q146ft7_8,q146ft7_11,q146ft7_13,q146ft7_14,q146ft7_18,q146ft7_19,r121e_39,r121e_105,r121e_116,r121e_40,r121e_106,r121e_42,r121e_6,r121e_114,r121e_7,r121e_8,r121e_9,r121e_10,r121e_118,r121e_143,r121e_157,r121e_165,r121e_166,r121b_39,r121b_105,r121b_116,r121b_40,r121b_106,r121b_42,r121b_6,r121b_114,r121b_7,r121b_8,r121b_9,r121b_10,r121b_118,r121b_143,r121b_157,r121b_165,r121b_166,r123a_39,r123a_105,r123a_116,r123a_40,r123a_106,r123a_42,r123a_6,r123a_114,r123a_7,r123a_8,r123a_9,r123a_10,r123a_118,r123a_143,r123a_157,r123a_165,r123a_166,r123b_39,r123b_105,r123b_116,r123b_40,r123b_106,r123b_42,r123b_6,r123b_114,r123b_7,r123b_8,r123b_9,r123b_10,r123b_118,r123b_143,r123b_157,r123b_165,r123b_166,r27b_39,r27b_105,r27b_116,r27b_40,r27b_106,r27b_42,r27b_6,r27b_114,r27b_7,r27b_8,r27b_9,r27b_10,r27b_118,r27b_143,r27b_157,r27b_165,r27b_166,r27a_39,r27a_105,r27a_116,r27a_40,r27a_106,r27a_42,r27a_6,r27a_114,r27a_7,r27a_8,r27a_9,r27a_10,r27a_118,r27a_143,r27a_157,r27a_165,r27a_166,r121ax_7,r121ax_13,r121ax_19,r121ax_20,r121ax_25,r121bx_7,r121bx_13,r121bx_19,r121bx_20,r121bx_25,r123ax_7,r123ax_13,r123ax_19,r123ax_20,r123ax_25,r121dx_7,r121dx_13,r121dx_19,r121dx_20,r121dx_25,r121ex_7,r121ex_13,r121ex_19,r121ex_20,r121ex_25,r123bx_7,r123bx_13,r123bx_19,r123bx_20,r123bx_25,r121cx_7,r121cx_13,r121cx_19,r121cx_20,r121cx_25,r27cx_7,r27cx_13,r27cx_19,r27cx_20,r27cx_25,r27ax_7,r27ax_13,r27ax_19,r27ax_20,r27ax_25,r27bx_7,r27bx_13,r27bx_19,r27bx_20,r27bx_25,q146ft8_1,q146ft8_2,q146ft8_3,q146ft8_4,q146ft8_5,q146ft8_6,q146ft8_8,q146ft8_9,q146ft8_11,q146ft8_12,q146ft8_13,q146ft8_14,q146ft8_15,q146ft8_16,q146ft8_18,q146ft8_19,r121e_154,r121b_154,r123a_154,r123b_154,r27b_154,r27a_154,r121ax_6,r121bx_6,r123ax_6,r121dx_6,r121ex_6,r123bx_6,r121cx_6,r27cx_6,r27ax_6,r27bx_6,q266t1_1,q266t1_2,q266t1_3,q266t1_4,q266t1_5,q266t2_1,q266t2_2,q266t2_3,q266t2_4,q266t2_5,q267t1_1,q267t1_2,q267t1_3,q267t1_4,q267t1_5,q267t1_6,q267t2_1,q267t2_2,q267t2_3,q267t2_4,q267t2_5,q267t2_6,q268t1_1,q268t1_2,q268t1_3,q268t1_4,q268t1_5,q268t2_1,q268t2_2,q268t2_3,q268t2_4,q268t2_5,q269t1_1,q269t1_2,q269t1_3,q269t1_4,q269t1_5,q269t2_1,q269t2_2,q269t2_3,q269t2_4,q269t2_5,q270t1_1,q270t1_2,q270t1_3,q270t1_4,q270t1_5,q270t1_6,q270t1_7,q270t2_1,q270t2_2,q270t2_3,q270t2_4,q270t2_5,q270t2_6,q270t2_7,q271t1_1,q271t1_2,q271t1_3,q271t1_4,q271t1_5,q271t1_6,q271t3_1,q271t3_2,q271t3_3,q271t3_4,q271t3_5,q271t3_6,r284_1,r284_2,r284_9,r284_27,r284_57,r284_59,r284_86,r285_1,r285_2,r285_9,r285_27,r285_57,r285_59,r285_86,r284_39,r284_105,r284_116,r284_40,r284_106,r284_42,r284_6,r284_114,r284_7,r284_8,r284_9,r284_10,r284_118,r284_143,r284_157,r284_165,r284_166,r284_154,r285_39,r285_105,r285_116,r285_40,r285_106,r285_42,r285_6,r285_114,r285_7,r285_8,r285_9,r285_10,r285_118,r285_143,r285_157,r285_165,r285_166,r285_154,r284x_7,r284x_13,r284x_19,r284x_20,r284x_25,r284x_6,r285x_7,r285x_13,r285x_19,r285x_20,r285x_25,r285x_6";// dashboard variable value
            //string questions = "r284_1,r284_2,r284_9,r284_27,r284_57,r284_59,r284_86,r285_1,r285_2,r285_9,r285_27,r285_57,r285_59,r285_86,r284_39,r284_105,r284_116,r284_40,r284_106,r284_42,r284_6,r284_114,r284_7,r284_8,r284_9,r284_10,r284_118,r284_143,r284_157,r284_165,r284_166,r284_154,r285_39,r285_105,r285_116,r285_40,r285_106,r285_42,r285_6,r285_114,r285_7,r285_8,r285_9,r285_10,r285_118,r285_143,r285_157,r285_165,r285_166,r285_154,r284x_7,r284x_13,r284x_19,r284x_20,r284x_25,r284x_6,r285x_7,r285x_13,r285x_19,r285x_20,r285x_25,r285x_6";
            string[] spss_variable_name = questions.Split(',');
            SpssReader spssDataset;
            //using (FileStream fileStream = new FileStream(@"D:\Mysql_to_Xl\HH-All.sav", FileMode.Open, FileAccess.Read, FileShare.Read, 2048 * 10, FileOptions.SequentialScan))
            using (FileStream fileStream = new FileStream(@"C:\Users\rahul\Desktop\HH_YY_NOV2018\HH_NOV2018\HH_Bis_Nov2018.sav", FileMode.Open, FileAccess.Read, FileShare.Read, 2048 * 10, FileOptions.SequentialScan))
            {

                spssDataset = new SpssReader(fileStream); // Create the reader, this will read the file header


                foreach (string spss_v in spss_variable_name)
                {
                    foreach (var variable in spssDataset.Variables)  // Iterate through all the varaibles
                    {

                        if (variable.Name.Equals(spss_v))
                        {
                            foreach (KeyValuePair<double, string> label in variable.ValueLabels)
                            {
                                string VARIABLE_NAME = spss_v;
                                string VARIABLE_NAME_SUB_NAME = variable.Name;
                                string VARIABLE_ID = label.Key.ToString();
                                string VARIABLE_VALUE = label.Value;
                                string VARIABLE_NAME_QUESTION = variable.Label;
                                string BASE_VARIABLE_NAME = variable.Name;
                                //iobj.insert_Dashboard_variable_values(VARIABLE_NAME, VARIABLE_NAME_SUB_NAME, VARIABLE_ID, VARIABLE_VALUE, VARIABLE_NAME_QUESTION, SURVEY_ID, country, BASE_VARIABLE_NAME, SURVEY_PERIOD);
                            }
                        }
                    }
                }

                //..............................................................................................

                // Iterate through all data rows in the file
                foreach (var record in spssDataset.Records)
                {
                    string userID = null;
                    //decimal weightage = 0;
                    decimal weightage = 0;
                    string u_id = "-- Not Available --";
                    string gender = "-- Not Available --";
                    string favouriteBrand = "-- Not Available --";
                    string bumo = "-- Not Available --";
                    string AdTom = "-- Not Available --";
                    string BrTom = "-- Not Available --";
                    string location = "-- Not Available --";
                    string AgeGroup = "-- Not Available --";
                    string ses = "-- Not Available --";
                    string period = "-- Not Available --";
                    string AdSpontRomaKelapa = "-- Not Available --";
                    string AdSpontRomaMalkist = "-- Not Available --";
                    string AdSpontSlaiOLai= "-- Not Available --";
                    string AdSpontRomaMarieSusu= "-- Not Available --";
                    string AdSpontRomaMalkistAbon= "-- Not Available --";
                    string AdSpontRomaSariGandumCokelat= "-- Not Available --";
                    string AdSpontBiskuat= "-- Not Available --";
                    string AdSpontBetter= "-- Not Available --";
                    string AdSpontBiskuatCoklatSusu= "-- Not Available --";
                    string AdSpontBiskuatEnergi= "-- Not Available --";
                    string AdSpontBiskuatEnergiCoklat= "-- Not Available --";
                    string AdSpontBiskuatSusu= "-- Not Available --";
                    string AdSpontOreo= "-- Not Available --";
                    string AdSpontSOLTwice= "-- Not Available --";
                    string AdSpontRomaMalkistCoklat= "-- Not Available --";
                    string AdSpontTwice= "-- Not Available --";
                    string AdSpontBelvita= "-- Not Available --";
                    string BrSpontRomaKelapa= "-- Not Available --";
                    string BrSpontRomaMalkist= "-- Not Available --";
                    string BrSpontSlaiOLai= "-- Not Available --";
                    string BrSpontRomaMarieSusu= "-- Not Available --";
                    string BrSpontRomaMalkistAbon= "-- Not Available --";
                    string BrSpontRomaSariGandumCokelat= "-- Not Available --";
                    string BrSpontBiskuat= "-- Not Available --";
                    string BrSpontBetter= "-- Not Available --";
                    string BrSpontBiskuatCoklatSusu= "-- Not Available --";
                    string BrSpontBiskuatEnergi= "-- Not Available --";
                    string BrSpontBiskuatEnergiCoklat= "-- Not Available --";
                    string BrSpontBiskuatSusu= "-- Not Available --";
                    string BrSpontOreo= "-- Not Available --";
                    string BrSpontSOLTwice= "-- Not Available --";
                    string BrSpontRomaMalkistCoklat= "-- Not Available --";
                    string BrSpontTwice = "-- Not Available --";
                    string BrSpontBelvita= "-- Not Available --";
                    string BrAidRomaKelapa= "-- Not Available --";
                    string BrAidRomaMalkist= "-- Not Available --";
                    string BrAidSlaiOLai= "-- Not Available --";
                    string BrAidRomaMarieSusu= "-- Not Available --";
                    string BrAidRomaMalkistAbon= "-- Not Available --";
                    string BrAidRomaSariGandumCokelat= "-- Not Available --";
                    string BrAidBiskuat= "-- Not Available --";
                    string BrAidBetter= "-- Not Available --";
                    string BrAidBiskuatCoklatSusu= "-- Not Available --";
                    string BrAidBiskuatEnergi= "-- Not Available --";
                    string BrAidBiskuatEnergiCoklat= "-- Not Available --";
                    string BrAidBiskuatSusu= "-- Not Available --";
                    string BrAidOreo= "-- Not Available --";
                    string BrAidSOLTwice= "-- Not Available --";
                    string BrAidRomaMalkistCoklat= "-- Not Available --";
                    string BrAidTwice= "-- Not Available --";
                    string BrAidBelvita= "-- Not Available --";
                    string AdAidRomaKelapa= "-- Not Available --";
                    string AdAidRomaMalkist= "-- Not Available --";
                    string AdAidSlaiOLai= "-- Not Available --";
                    string AdAidRomaMarieSusu= "-- Not Available --";
                    string AdAidRomaMalkistAbon= "-- Not Available --";
                    string AdAidRomaSariGandumCokelat= "-- Not Available --";
                    string AdAidBiskuat= "-- Not Available --";
                    string AdAidBetter= "-- Not Available --";
                    string AdAidBiskuatCoklatSusu= "-- Not Available --";
                    string AdAidBiskuatEnergi= "-- Not Available --";
                    string AdAidBiskuatEnergiCoklat= "-- Not Available --";
                    string AdAidBiskuatSusu= "-- Not Available --";
                    string AdAidOreo= "-- Not Available --";
                    string AdAidSOLTwice= "-- Not Available --";
                    string AdAidRomaMalkistCoklat= "-- Not Available --";
                    string AdAidTwice= "-- Not Available --";
                    string AdAidBelvita= "-- Not Available --";
                    string CurConsRomaKelapa= "-- Not Available --";
                    string CurConsRomaMalkist = "-- Not Available --";
                    string CurConsSlaiOLai= "-- Not Available --";
                    string CurConsRomaMarieSusu= "-- Not Available --";
                    string CurConsRomaMalkistAbon= "-- Not Available --";
                    string CurConsRomaSariGandumCokelat= "-- Not Available --";
                    string CurConsBiskuat= "-- Not Available --";
                    string CurConsBetter= "-- Not Available --";
                    string CurConsBiskuatCoklatSusu= "-- Not Available --";
                    string CurConsBiskuatEnergi= "-- Not Available --";
                    string CurConsBiskuatEnergiCoklat= "-- Not Available --";
                    string CurConsBiskuatSusu= "-- Not Available --";
                    string CurConsOreo= "-- Not Available --";
                    string CurConsSOLTwice= "-- Not Available --";
                    string CurConsRomaMalkistCoklat= "-- Not Available --";
                    string CurConsTwice= "-- Not Available --";
                    string CurConsBelvita= "-- Not Available --";
                    string ConsLMRomaKelapa= "-- Not Available --";
                    string ConsLMRomaMalkist= "-- Not Available --";
                    string ConsLMSlaiOLai= "-- Not Available --";
                    string ConsLMRomaMarieSusu= "-- Not Available --";
                    string ConsLMRomaMalkistAbon= "-- Not Available --";
                    string ConsLMRomaSariGandumCokelat= "-- Not Available --";
                    string ConsLMBiskuat= "-- Not Available --";
                    string ConsLMBetter= "-- Not Available --";
                    string ConsLMBiskuatCoklatSusu= "-- Not Available --";
                    string ConsLMBiskuatEnergi= "-- Not Available --";
                    string ConsLMBiskuatEnergiCoklat= "-- Not Available --";
                    string ConsLMBiskuatSusu= "-- Not Available --";
                    string ConsLMOreo= "-- Not Available --";
                    string ConsLMSOLTwice= "-- Not Available --";
                    string ConsLMRomaMalkistCoklat= "-- Not Available --";
                    string ConsLMTwice= "-- Not Available --";
                    string ConsLMBelvita= "-- Not Available --";
                    string BrTomNetKhongGuan= "-- Not Available --";
                    string BrTomNetRomaSariGandum= "-- Not Available --";
                    string BrTomNetRomaCrackers= "-- Not Available --";
                    string BrTomNetKGCrakers= "-- Not Available --";
                    string BrTomNetSlaiOlai= "-- Not Available --";
                    string BrSpontNetKhongGuan= "-- Not Available --";
                    string BrSpontNetRomaSariGandum= "-- Not Available --";
                    string BrSpontNetRomaCrackers= "-- Not Available --";
                    string BrSpontNetKGCrakers= "-- Not Available --";
                    string BrSpontNetSlaiOlai= "-- Not Available --";
                    string BrAidNetKhongGuan= "-- Not Available --";
                    string BrAidNetRomaSariGandum= "-- Not Available --";
                    string BrAidNetRomaCrackers= "-- Not Available --";
                    string BrAidNetKGCrakers= "-- Not Available --";
                    string BrAidNetSlaiOlai= "-- Not Available --";
                    string AdTomNetKhongGuan= "-- Not Available --";
                    string AdTomNetRomaSariGandum= "-- Not Available --";
                    string AdTomNetRomaCrackers= "-- Not Available --";
                    string AdTomNetKGCrakers= "-- Not Available --";
                    string AdTomNetSlaiOlai= "-- Not Available --";
                    string AdSpontNetKhongGuan= "-- Not Available --";
                    string AdSpontNetRomaSariGandum= "-- Not Available --";
                    string AdSpontNetRomaCrackers= "-- Not Available --";
                    string AdSpontNetKGCrakers= "-- Not Available --";
                    string AdSpontNetSlaiOlai= "-- Not Available --";
                    string AdAidNetKhongGuan= "-- Not Available --";
                    string AdAidNetRomaSariGandum= "-- Not Available --";
                    string AdAidNetRomaCrackers= "-- Not Available --";
                    string AdAidNetKGCrakers= "-- Not Available --";
                    string AdAidNetSlaiOlai= "-- Not Available --";
                    string NetFavBrandKhongGuan= "-- Not Available --";
                    string NetFavBrandRomaSariGandum= "-- Not Available --";
                    string NetFavBrandRomaCrackers= "-- Not Available --";
                    string NetFavBrandKGCrakers= "-- Not Available --";
                    string NetFavBrandSlaiOlai= "-- Not Available --";
                    string NetBumoKhongGuan= "-- Not Available --";
                    string NetBumoRomaSariGandum= "-- Not Available --";
                    string NetBumoRomaCrackers= "-- Not Available --";
                    string NetBumoKGCrakers= "-- Not Available --";
                    string NetBumoSlaiOlai= "-- Not Available --";
                    string NetConsuLMKhongGuan= "-- Not Available --";
                    string NetConsuLMRomaSariGandum= "-- Not Available --";
                    string NetConsuLMRomaCrackers= "-- Not Available --";
                    string NetConsuLMKGCrakers= "-- Not Available --";
                    string NetConsuLMSlaiOlai= "-- Not Available --";
                    string NetConCurKhongGuan= "-- Not Available --";
                    string NetConCurRomaSariGandum= "-- Not Available --";
                    string NetConCurRomaCrackers= "-- Not Available --";
                    string NetConCurKGCrakers= "-- Not Available --";
                    string NetConCurSlaiOlai= "-- Not Available --";
                    string q146ft1_14 = "-- Not Available --";
                    string q146ft1_15 = "-- Not Available --";
                    string q146ft1_16 = "-- Not Available --";
                    string q146ft1_18 = "-- Not Available --";
                    string q146ft1_19 = "-- Not Available --";
                    string q146ft1_4 = "-- Not Available --";
                    string q146ft1_5 = "-- Not Available --";
                    string q146ft6_8 = "-- Not Available --";
                    string q146ft6_9 = "-- Not Available --";
                    string q146ft6_11 = "-- Not Available --";
                    string q146ft6_12 = "-- Not Available --";
                    string q146ft6_13 = "-- Not Available --";
                    string q146ft6_14 = "-- Not Available --";
                    string q146ft2_2 = "-- Not Available --";
                    string q146ft2_4 = "-- Not Available --";
                    string q146ft2_5 = "-- Not Available --";
                    string q146ft2_8 = "-- Not Available --";
                    string q146ft2_11 = "-- Not Available --";
                    string q146ft2_13 = "-- Not Available --";
                    string q146ft2_14 = "-- Not Available --";
                    string q146ft2_18 = "-- Not Available --";
                    string q146ft2_19 = "-- Not Available --";
                    string q146ft7_2 = "-- Not Available --";
                    string q146ft7_4 = "-- Not Available --";
                    string q146ft7_5 = "-- Not Available --";
                    string q146ft7_8 = "-- Not Available --";
                    string q146ft7_11 = "-- Not Available --";
                    string q146ft7_13 = "-- Not Available --";
                    string q146ft7_14 = "-- Not Available --";
                    string q146ft7_18 = "-- Not Available --";
                    string q146ft7_19 = "-- Not Available --";
                    string q146ft8_1 = "-- Not Available --";
                    string q146ft8_2 = "-- Not Available --";
                    string q146ft8_3 = "-- Not Available --";
                    string q146ft8_4 = "-- Not Available --";
                    string q146ft8_5 = "-- Not Available --";
                    string q146ft8_6 = "-- Not Available --";
                    string q146ft8_8 = "-- Not Available --";
                    string q146ft8_9 = "-- Not Available --";
                    string q146ft8_11 = "-- Not Available --";
                    string q146ft8_12 = "-- Not Available --";
                    string q146ft8_13 = "-- Not Available --";
                    string q146ft8_14 = "-- Not Available --";
                    string q146ft8_15 = "-- Not Available --";
                    string q146ft8_16 = "-- Not Available --";
                    string q146ft8_18 = "-- Not Available --";
                    string q146ft8_19 = "-- Not Available --";
                    string AsSpontBisvitSelimut = "-- Not Available --";
                    string BrSpontBisvitSelimut = "-- Not Available --";
                    string BrAidBisvitSelimut = "-- Not Available --";
                    string AdAidBisvitSelimut = "-- Not Available --";
                    string CurConsBisvitSelimut = "-- Not Available --";
                    string ConsLMBisvitSelimut = "-- Not Available --";
                    string BrTomNetHATARI = "-- Not Available --";
                    string BrSpontNetHATARI = "-- Not Available --";
                    string BrAidNetHATARI = "-- Not Available --";
                    string AdTomNetHATARI = "-- Not Available --";
                    string AdSpontNetHATARI = "-- Not Available --";
                    string AdAidNetHATARI = "-- Not Available --";
                    string NetFavBrandHATARI = "-- Not Available --";
                    string NetBumoHATARI = "-- Not Available --";
                    string NetConsuLMHATARI = "-- Not Available --";
                    string NetConCurHATARI = "-- Not Available --";
                    string q266t1_1 = "-- Not Available --";
                    string q266t1_2 = "-- Not Available --";
                    string q266t1_3 = "-- Not Available --";
                    string q266t1_4 = "-- Not Available --";
                    string q266t1_5 = "-- Not Available --";
                    string q266t2_1 = "-- Not Available --";
                    string q266t2_2 = "-- Not Available --";
                    string q266t2_3 = "-- Not Available --";
                    string q266t2_4 = "-- Not Available --";
                    string q266t2_5 = "-- Not Available --";
                    string q267t1_1 = "-- Not Available --";
                    string q267t1_2 = "-- Not Available --";
                    string q267t1_3 = "-- Not Available --";
                    string q267t1_4 = "-- Not Available --";
                    string q267t1_5 = "-- Not Available --";
                    string q267t1_6 = "-- Not Available --";
                    string q267t2_1 = "-- Not Available --";
                    string q267t2_2 = "-- Not Available --";
                    string q267t2_3 = "-- Not Available --";
                    string q267t2_4 = "-- Not Available --";
                    string q267t2_5 = "-- Not Available --";
                    string q267t2_6 = "-- Not Available --";
                    string q268t1_1 = "-- Not Available --";
                    string q268t1_2 = "-- Not Available --";
                    string q268t1_3 = "-- Not Available --";
                    string q268t1_4 = "-- Not Available --";
                    string q268t1_5 = "-- Not Available --";
                    string q268t2_1 = "-- Not Available --";
                    string q268t2_2 = "-- Not Available --";
                    string q268t2_3 = "-- Not Available --";
                    string q268t2_4 = "-- Not Available --";
                    string q268t2_5 = "-- Not Available --";
                    string q269t1_1 = "-- Not Available --";
                    string q269t1_2 = "-- Not Available --";
                    string q269t1_3 = "-- Not Available --";
                    string q269t1_4 = "-- Not Available --";
                    string q269t1_5 = "-- Not Available --";
                    string q269t2_1 = "-- Not Available --";
                    string q269t2_2 = "-- Not Available --";
                    string q269t2_3 = "-- Not Available --";
                    string q269t2_4 = "-- Not Available --";
                    string q269t2_5 = "-- Not Available --";
                    string q270t1_1 = "-- Not Available --";
                    string q270t1_2 = "-- Not Available --";
                    string q270t1_3 = "-- Not Available --";
                    string q270t1_4 = "-- Not Available --";
                    string q270t1_5 = "-- Not Available --";
                    string q270t1_6 = "-- Not Available --";
                    string q270t1_7 = "-- Not Available --";
                    string q270t2_1 = "-- Not Available --";
                    string q270t2_2 = "-- Not Available --";
                    string q270t2_3 = "-- Not Available --";
                    string q270t2_4 = "-- Not Available --";
                    string q270t2_5 = "-- Not Available --";
                    string q270t2_6 = "-- Not Available --";
                    string q270t2_7 = "-- Not Available --";
                    string q271t1_1 = "-- Not Available --";
                    string q271t1_2 = "-- Not Available --";
                    string q271t1_3 = "-- Not Available --";
                    string q271t1_4 = "-- Not Available --";
                    string q271t1_5 = "-- Not Available --";
                    string q271t1_6 = "-- Not Available --";
                    string q271t3_1 = "-- Not Available --";
                    string q271t3_2 = "-- Not Available --";
                    string q271t3_3 = "-- Not Available --";
                    string q271t3_4 = "-- Not Available --";
                    string q271t3_5 = "-- Not Available --";
                    string q271t3_6 = "-- Not Available --";

                    string ConsP1WRomaKelapa = "-- Not Available --";
                    string ConsP1WRomaMalkist = "-- Not Available --";
                    string ConsP1WSlaiOLai = "-- Not Available --";
                    string ConsP1WRomaMarieSusu = "-- Not Available --";
                    string ConsP1WRomaMalkistAbon = "-- Not Available --";
                    string ConsP1WRomaSariGandumCokelat = "-- Not Available --";
                    string ConsP1WBiskuat = "-- Not Available --";
                    string ConsP1WBetter = "-- Not Available --";
                    string ConsP1WBiskuatCoklatSusu = "-- Not Available --";
                    string ConsP1WBiskuatEnergi = "-- Not Available --";
                    string ConsP1WBiskuatEnergiCoklat = "-- Not Available --";
                    string ConsP1WBiskuatSusu = "-- Not Available --";
                    string ConsP1WOreo = "-- Not Available --";
                    string ConsP1WSOLTwice = "-- Not Available --";
                    string ConsP1WRomaMalkistCoklat = "-- Not Available --";
                    string ConsP1WTwice = "-- Not Available --";
                    string ConsP1WBelvita = "-- Not Available --";
                    string ConsP1WBisvitSelimut = "-- Not Available --";
                    string ConsP1DRomaKelapa = "-- Not Available --";
                    string ConsP1DRomaMalkist = "-- Not Available --";
                    string ConsP1DSlaiOLai = "-- Not Available --";
                    string ConsP1DRomaMarieSusu = "-- Not Available --";
                    string ConsP1DRomaMalkistAbon = "-- Not Available --";
                    string ConsP1DRomaSariGandumCokelat = "-- Not Available --";
                    string ConsP1DBiskuat = "-- Not Available --";
                    string ConsP1DBetter = "-- Not Available --";
                    string ConsP1DBiskuatCoklatSusu = "-- Not Available --";
                    string ConsP1DBiskuatEnergi = "-- Not Available --";
                    string ConsP1DBiskuatEnergiCoklat = "-- Not Available --";
                    string ConsP1DBiskuatSusu = "-- Not Available --";
                    string ConsP1DOreo = "-- Not Available --";
                    string ConsP1DSOLTwice = "-- Not Available --";
                    string ConsP1DRomaMalkistCoklat = "-- Not Available --";
                    string ConsP1DTwice = "-- Not Available --";
                    string ConsP1DBelvita = "-- Not Available --";
                    string ConsP1DBisvitSelimut = "-- Not Available --";
                    string r284x_7 = "-- Not Available --";
                    string r284x_13 = "-- Not Available --";
                    string r284x_19 = "-- Not Available --";
                    string r284x_20 = "-- Not Available --";
                    string r284x_25 = "-- Not Available --";
                    string r284x_6 = "-- Not Available --";
                    string r285x_7 = "-- Not Available --";
                    string r285x_13 = "-- Not Available --";
                    string r285x_19 = "-- Not Available --";
                    string r285x_20 = "-- Not Available --";
                    string r285x_25 = "-- Not Available --";
                    string r285x_6 = "-- Not Available --";


                     foreach (var variable in spssDataset.Variables)
                    {
                        foreach (string spss_v in spss_variable_name)
                        {
                            if (variable.Name.Equals(spss_v))
                            {

                                // Console.Write(variable.Name);
                                //Console.Write(':');
                             
                                if (variable.Name.Equals("iobs"))
                                {
                                    u_id = Convert.ToString(record.GetValue(variable));
                                    userID = find_UserId(SURVEY_ID, SURVEY_PERIOD, u_id);

                                }
                                if (variable.Name.Equals("weight"))
                                {
                                    weightage = Convert.ToDecimal(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r8"))
                                {
                                    gender = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r1"))
                                {
                                    location = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121c"))
                                {
                                    favouriteBrand = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27c"))
                                {
                                    bumo = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121d"))
                                {
                                    AdTom = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121a"))
                                {
                                    BrTom = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r7"))
                                {
                                    AgeGroup = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r12"))
                                {
                                    ses = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r2"))
                                {
                                    period = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121e_39"))
                                {
                                    AdSpontRomaKelapa = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121e_105"))
                                {
                                    AdSpontRomaMalkist = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121e_116"))
                                {
                                    AdSpontSlaiOLai = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121e_40"))
                                {
                                    AdSpontRomaMarieSusu = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121e_106"))
                                {
                                    AdSpontRomaMalkistAbon = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121e_42"))
                                {
                                    AdSpontRomaSariGandumCokelat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121e_6"))
                                {
                                    AdSpontBiskuat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121e_114"))
                                {
                                    AdSpontBetter = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121e_7"))
                                {
                                    AdSpontBiskuatCoklatSusu = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121e_8"))
                                {
                                    AdSpontBiskuatEnergi = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121e_9"))
                                {
                                    AdSpontBiskuatEnergiCoklat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121e_10"))
                                {
                                    AdSpontBiskuatSusu = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121e_118"))
                                {
                                    AdSpontOreo = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121e_143"))
                                {
                                    AdSpontSOLTwice = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121e_157"))
                                {
                                    AdSpontRomaMalkistCoklat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121e_165"))
                                {
                                    AdSpontTwice = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121e_166"))
                                {
                                    AdSpontBelvita = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121b_39"))
                                {
                                    BrSpontRomaKelapa = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121b_105"))
                                {
                                    BrSpontRomaMalkist = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121b_116"))
                                {
                                    BrSpontSlaiOLai = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121b_40"))
                                {
                                    BrSpontRomaMarieSusu = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121b_106"))
                                {
                                    BrSpontRomaMalkistAbon = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121b_42"))
                                {
                                    BrSpontRomaSariGandumCokelat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121b_6"))
                                {
                                    BrSpontBiskuat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121b_114"))
                                {
                                    BrSpontBetter = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121b_7"))
                                {
                                    BrSpontBiskuatCoklatSusu = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121b_8"))
                                {
                                    BrSpontBiskuatEnergi = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121b_9"))
                                {
                                    BrSpontBiskuatEnergiCoklat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121b_10"))
                                {
                                    BrSpontBiskuatSusu = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121b_118"))
                                {
                                    BrSpontOreo = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121b_143"))
                                {
                                    BrSpontSOLTwice = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121b_157"))
                                {
                                    BrSpontRomaMalkistCoklat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121b_165"))
                                {
                                    BrSpontTwice = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121b_166"))
                                {
                                    BrSpontBelvita = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123a_39"))
                                {
                                    BrAidRomaKelapa = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123a_105"))
                                {
                                    BrAidRomaMalkist = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123a_116"))
                                {
                                    BrAidSlaiOLai = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123a_40"))
                                {
                                    BrAidRomaMarieSusu = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123a_106"))
                                {
                                    BrAidRomaMalkistAbon = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123a_42"))
                                {
                                    BrAidRomaSariGandumCokelat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123a_6"))
                                {
                                    BrAidBiskuat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123a_114"))
                                {
                                    BrAidBetter = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123a_7"))
                                {
                                    BrAidBiskuatCoklatSusu = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123a_8"))
                                {
                                    BrAidBiskuatEnergi = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123a_9"))
                                {
                                    BrAidBiskuatEnergiCoklat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123a_10"))
                                {
                                    BrAidBiskuatSusu = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123a_118"))
                                {
                                    BrAidOreo = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123a_143"))
                                {
                                    BrAidSOLTwice = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123a_157"))
                                {
                                    BrAidRomaMalkistCoklat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123a_165"))
                                {
                                    BrAidTwice = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123a_166"))
                                {
                                    BrAidBelvita = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123b_39"))
                                {
                                    AdAidRomaKelapa = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123b_105"))
                                {
                                    AdAidRomaMalkist = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123b_116"))
                                {
                                    AdAidSlaiOLai = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123b_40"))
                                {
                                    AdAidRomaMarieSusu = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123b_106"))
                                {
                                    AdAidRomaMalkistAbon = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123b_42"))
                                {
                                    AdAidRomaSariGandumCokelat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123b_6"))
                                {
                                    AdAidBiskuat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123b_114"))
                                {
                                    AdAidBetter = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123b_7"))
                                {
                                    AdAidBiskuatCoklatSusu = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123b_8"))
                                {
                                    AdAidBiskuatEnergi = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123b_9"))
                                {
                                    AdAidBiskuatEnergiCoklat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123b_10"))
                                {
                                    AdAidBiskuatSusu = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123b_118"))
                                {
                                    AdAidOreo = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123b_143"))
                                {
                                    AdAidSOLTwice = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123b_157"))
                                {
                                    AdAidRomaMalkistCoklat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123b_165"))
                                {
                                    AdAidTwice = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123b_166"))
                                {
                                    AdAidBelvita = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27b_39"))
                                {
                                    CurConsRomaKelapa = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27b_105"))
                                {
                                    CurConsRomaMalkist = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27b_116"))
                                {
                                    CurConsSlaiOLai = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27b_40"))
                                {
                                    CurConsRomaMarieSusu = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27b_106"))
                                {
                                    CurConsRomaMalkistAbon = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27b_42"))
                                {
                                    CurConsRomaSariGandumCokelat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27b_6"))
                                {
                                    CurConsBiskuat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27b_114"))
                                {
                                    CurConsBetter = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27b_7"))
                                {
                                    CurConsBiskuatCoklatSusu = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27b_8"))
                                {
                                    CurConsBiskuatEnergi = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27b_9"))
                                {
                                    CurConsBiskuatEnergiCoklat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27b_10"))
                                {
                                    CurConsBiskuatSusu = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27b_118"))
                                {
                                    CurConsOreo = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27b_143"))
                                {
                                    CurConsSOLTwice = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27b_157"))
                                {
                                    CurConsRomaMalkistCoklat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27b_165"))
                                {
                                    CurConsTwice = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27b_166"))
                                {
                                    CurConsBelvita = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27a_39"))
                                {
                                    ConsLMRomaKelapa = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27a_105"))
                                {
                                    ConsLMRomaMalkist = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27a_116"))
                                {
                                    ConsLMSlaiOLai = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27a_40"))
                                {
                                    ConsLMRomaMarieSusu = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27a_106"))
                                {
                                    ConsLMRomaMalkistAbon = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27a_42"))
                                {
                                    ConsLMRomaSariGandumCokelat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27a_6"))
                                {
                                    ConsLMBiskuat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27a_114"))
                                {
                                    ConsLMBetter = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27a_7"))
                                {
                                    ConsLMBiskuatCoklatSusu = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27a_8"))
                                {
                                    ConsLMBiskuatEnergi = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27a_9"))
                                {
                                    ConsLMBiskuatEnergiCoklat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27a_10"))
                                {
                                    ConsLMBiskuatSusu = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27a_118"))
                                {
                                    ConsLMOreo = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27a_143"))
                                {
                                    ConsLMSOLTwice = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27a_157"))
                                {
                                    ConsLMRomaMalkistCoklat = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27a_165"))
                                {
                                    ConsLMTwice = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27a_166"))
                                {
                                    ConsLMBelvita = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121ax_7"))
                                {
                                    BrTomNetKhongGuan = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121ax_13"))
                                {
                                    BrTomNetRomaSariGandum = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121ax_19"))
                                {
                                    BrTomNetRomaCrackers = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121ax_20"))
                                {
                                    BrTomNetKGCrakers = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121ax_25"))
                                {
                                    BrTomNetSlaiOlai = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121bx_7"))
                                {
                                    BrSpontNetKhongGuan = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121bx_13"))
                                {
                                    BrSpontNetRomaSariGandum = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121bx_19"))
                                {
                                    BrSpontNetRomaCrackers = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121bx_20"))
                                {
                                    BrSpontNetKGCrakers = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121bx_25"))
                                {
                                    BrSpontNetSlaiOlai = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123ax_7"))
                                {
                                    BrAidNetKhongGuan = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123ax_13"))
                                {
                                    BrAidNetRomaSariGandum = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123ax_19"))
                                {
                                    BrAidNetRomaCrackers = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123ax_20"))
                                {
                                    BrAidNetKGCrakers = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123ax_25"))
                                {
                                    BrAidNetSlaiOlai = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121dx_7"))
                                {
                                    AdTomNetKhongGuan = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121dx_13"))
                                {
                                    AdTomNetRomaSariGandum = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121dx_19"))
                                {
                                    AdTomNetRomaCrackers = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121dx_20"))
                                {
                                    AdTomNetKGCrakers = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121dx_25"))
                                {
                                    AdTomNetSlaiOlai = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121ex_7"))
                                {
                                    AdSpontNetKhongGuan = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121ex_13"))
                                {
                                    AdSpontNetRomaSariGandum = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121ex_19"))
                                {
                                    AdSpontNetRomaCrackers = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121ex_20"))
                                {
                                    AdSpontNetKGCrakers = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121ex_25"))
                                {
                                    AdSpontNetSlaiOlai = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123bx_7"))
                                {
                                    AdAidNetKhongGuan = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123bx_13"))
                                {
                                    AdAidNetRomaSariGandum = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123bx_19"))
                                {
                                    AdAidNetRomaCrackers = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123bx_20"))
                                {
                                    AdAidNetKGCrakers = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r123bx_25"))
                                {
                                    AdAidNetSlaiOlai = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121cx_7"))
                                {
                                    NetFavBrandKhongGuan = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121cx_13"))
                                {
                                    NetFavBrandRomaSariGandum = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121cx_19"))
                                {
                                    NetFavBrandRomaCrackers = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121cx_20"))
                                {
                                    NetFavBrandKGCrakers = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r121cx_25"))
                                {
                                    NetFavBrandSlaiOlai = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27cx_7"))
                                {
                                    NetBumoKhongGuan = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27cx_13"))
                                {
                                    NetBumoRomaSariGandum = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27cx_19"))
                                {
                                    NetBumoRomaCrackers = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27cx_20"))
                                {
                                    NetBumoKGCrakers = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27cx_25"))
                                {
                                    NetBumoSlaiOlai = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27ax_7"))
                                {
                                    NetConsuLMKhongGuan = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27ax_13"))
                                {
                                    NetConsuLMRomaSariGandum = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27ax_19"))
                                {
                                    NetConsuLMRomaCrackers = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27ax_20"))
                                {
                                    NetConsuLMKGCrakers = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27ax_25"))
                                {
                                    NetConsuLMSlaiOlai = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27bx_7"))
                                {
                                    NetConCurKhongGuan = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27bx_13"))
                                {
                                    NetConCurRomaSariGandum = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27bx_19"))
                                {
                                    NetConCurRomaCrackers = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27bx_20"))
                                {
                                    NetConCurKGCrakers = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("r27bx_25"))
                                {
                                    NetConCurSlaiOlai = Convert.ToString(record.GetValue(variable));

                                }
                                if (variable.Name.Equals("q146ft1_14"))
                                {
                                    q146ft1_14 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft1_15"))
                                {
                                    q146ft1_15 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft1_16"))
                                {
                                    q146ft1_16 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft1_18"))
                                {
                                    q146ft1_18 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft1_19"))
                                {
                                    q146ft1_19 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft1_4"))
                                {
                                    q146ft1_4 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft1_5"))
                                {
                                    q146ft1_5 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft6_8"))
                                {
                                    q146ft6_8 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft6_9"))
                                {
                                    q146ft6_9 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft6_11"))
                                {
                                    q146ft6_11 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft6_12"))
                                {
                                    q146ft6_12 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft6_13"))
                                {
                                    q146ft6_13 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft6_14"))
                                {
                                    q146ft6_14 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft2_2"))
                                {
                                    q146ft2_2 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft2_4"))
                                {
                                    q146ft2_4 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft2_5"))
                                {
                                    q146ft2_5 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft2_8"))
                                {
                                    q146ft2_8 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft2_11"))
                                {
                                    q146ft2_11 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft2_13"))
                                {
                                    q146ft2_13 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft2_14"))
                                {
                                    q146ft2_14 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft2_18"))
                                {
                                    q146ft2_18 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft2_19"))
                                {
                                    q146ft2_19 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft7_2"))
                                {
                                    q146ft7_2 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft7_4"))
                                {
                                    q146ft7_4 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft7_5"))
                                {
                                    q146ft7_5 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft7_8"))
                                {
                                    q146ft7_8 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft7_11"))
                                {
                                    q146ft7_11 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft7_13"))
                                {
                                    q146ft7_13 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft7_14"))
                                {
                                    q146ft7_14 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft7_18"))
                                {
                                    q146ft7_18 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft7_19"))
                                {
                                    q146ft7_19 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft8_1"))
                                {
                                    q146ft8_1 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft8_2"))
                                {
                                    q146ft8_2 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft8_3"))
                                {
                                    q146ft8_3 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft8_4"))
                                {
                                    q146ft8_4 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft8_5"))
                                {
                                    q146ft8_5 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft8_6"))
                                {
                                    q146ft8_6 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft8_8"))
                                {
                                    q146ft8_8 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft8_9"))
                                {
                                    q146ft8_9 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft8_11"))
                                {
                                    q146ft8_11 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft8_12"))
                                {
                                    q146ft8_12 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft8_13"))
                                {
                                    q146ft8_13 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft8_14"))
                                {
                                    q146ft8_14 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft8_15"))
                                {
                                    q146ft8_15 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft8_16"))
                                {
                                    q146ft8_16 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft8_18"))
                                {
                                    q146ft8_18 = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q146ft8_19"))
                                {
                                    q146ft8_19 = Convert.ToString(record.GetValue(variable));
                                }

                                if (variable.Name.Equals("r121e_154"))
                                {
                                    AsSpontBisvitSelimut = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("r121b_154"))
                                {
                                    BrSpontBisvitSelimut = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("r123a_154"))
                                {
                                    BrAidBisvitSelimut = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("r123b_154"))
                                {
                                    AdAidBisvitSelimut = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("r27b_154"))
                                {
                                    CurConsBisvitSelimut = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("r27a_154"))
                                {
                                    ConsLMBisvitSelimut = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("r121ax_6"))
                                {
                                    BrTomNetHATARI = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("r121bx_6"))
                                {
                                    BrSpontNetHATARI = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("r123ax_6"))
                                {
                                    BrAidNetHATARI = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("r121dx_6"))
                                {
                                    AdTomNetHATARI = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("r121ex_6"))
                                {
                                    AdSpontNetHATARI = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("r123bx_6"))
                                {
                                    AdAidNetHATARI = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("r121cx_6"))
                                {
                                    NetFavBrandHATARI = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("r27cx_6"))
                                {
                                    NetBumoHATARI = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("r27ax_6"))
                                {
                                    NetConsuLMHATARI = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("r27bx_6"))
                                {
                                    NetConCurHATARI = Convert.ToString(record.GetValue(variable));
                                }
                                if (variable.Name.Equals("q266t1_1")) { q266t1_1 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q266t1_2")) { q266t1_2 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q266t1_3")) { q266t1_3 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q266t1_4")) { q266t1_4 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q266t1_5")) { q266t1_5 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q266t2_1")) { q266t2_1 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q266t2_2")) { q266t2_2 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q266t2_3")) { q266t2_3 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q266t2_4")) { q266t2_4 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q266t2_5")) { q266t2_5 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q267t1_1")) { q267t1_1 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q267t1_2")) { q267t1_2 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q267t1_3")) { q267t1_3 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q267t1_4")) { q267t1_4 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q267t1_5")) { q267t1_5 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q267t1_6")) { q267t1_6 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q267t2_1")) { q267t2_1 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q267t2_2")) { q267t2_2 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q267t2_3")) { q267t2_3 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q267t2_4")) { q267t2_4 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q267t2_5")) { q267t2_5 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q267t2_6")) { q267t2_6 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q268t1_1")) { q268t1_1 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q268t1_2")) { q268t1_2 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q268t1_3")) { q268t1_3 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q268t1_4")) { q268t1_4 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q268t1_5")) { q268t1_5 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q268t2_1")) { q268t2_1 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q268t2_2")) { q268t2_2 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q268t2_3")) { q268t2_3 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q268t2_4")) { q268t2_4 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q268t2_5")) { q268t2_5 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q269t1_1")) { q269t1_1 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q269t1_2")) { q269t1_2 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q269t1_3")) { q269t1_3 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q269t1_4")) { q269t1_4 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q269t1_5")) { q269t1_5 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q269t2_1")) { q269t2_1 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q269t2_2")) { q269t2_2 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q269t2_3")) { q269t2_3 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q269t2_4")) { q269t2_4 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q269t2_5")) { q269t2_5 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q270t1_1")) { q270t1_1 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q270t1_2")) { q270t1_2 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q270t1_3")) { q270t1_3 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q270t1_4")) { q270t1_4 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q270t1_5")) { q270t1_5 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q270t1_6")) { q270t1_6 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q270t1_7")) { q270t1_7 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q270t2_1")) { q270t2_1 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q270t2_2")) { q270t2_2 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q270t2_3")) { q270t2_3 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q270t2_4")) { q270t2_4 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q270t2_5")) { q270t2_5 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q270t2_6")) { q270t2_6 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q270t2_7")) { q270t2_7 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q271t1_1")) { q271t1_1 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q271t1_2")) { q271t1_2 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q271t1_3")) { q271t1_3 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q271t1_4")) { q271t1_4 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q271t1_5")) { q271t1_5 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q271t1_6")) { q271t1_6 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q271t3_1")) { q271t3_1 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q271t3_2")) { q271t3_2 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q271t3_3")) { q271t3_3 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q271t3_4")) { q271t3_4 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q271t3_5")) { q271t3_5 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("q271t3_6")) { q271t3_6 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284_39")) { ConsP1WRomaKelapa = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284_105")) { ConsP1WRomaMalkist = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284_116")) { ConsP1WSlaiOLai = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284_40")) { ConsP1WRomaMarieSusu = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284_106")) { ConsP1WRomaMalkistAbon = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284_42")) { ConsP1WRomaSariGandumCokelat = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284_6")) { ConsP1WBiskuat = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284_114")) { ConsP1WBetter = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284_7")) { ConsP1WBiskuatCoklatSusu = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284_8")) { ConsP1WBiskuatEnergi = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284_9")) { ConsP1WBiskuatEnergiCoklat = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284_10")) { ConsP1WBiskuatSusu = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284_118")) { ConsP1WOreo = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284_143")) { ConsP1WSOLTwice = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284_157")) { ConsP1WRomaMalkistCoklat = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284_165")) { ConsP1WTwice = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284_166")) { ConsP1WBelvita = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284_154")) { ConsP1WBisvitSelimut = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285_39")) { ConsP1DRomaKelapa = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285_105")) { ConsP1DRomaMalkist = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285_116")) { ConsP1DSlaiOLai = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285_40")) { ConsP1DRomaMarieSusu = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285_106")) { ConsP1DRomaMalkistAbon = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285_42")) { ConsP1DRomaSariGandumCokelat = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285_6")) { ConsP1DBiskuat = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285_114")) { ConsP1DBetter = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285_7")) { ConsP1DBiskuatCoklatSusu = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285_8")) { ConsP1DBiskuatEnergi = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285_9")) { ConsP1DBiskuatEnergiCoklat = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285_10")) { ConsP1DBiskuatSusu = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285_118")) { ConsP1DOreo = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285_143")) { ConsP1DSOLTwice = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285_157")) { ConsP1DRomaMalkistCoklat = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285_165")) { ConsP1DTwice = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285_166")) { ConsP1DBelvita = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285_154")) { ConsP1DBisvitSelimut = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284x_7")) { r284x_7 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284x_13")) { r284x_13 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284x_19")) { r284x_19 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284x_20")) { r284x_20 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284x_25")) { r284x_25 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r284x_6")) { r284x_6 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285x_7")) { r285x_7 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285x_13")) { r285x_13 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285x_19")) { r285x_19 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285x_20")) { r285x_20 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285x_25")) { r285x_25 = Convert.ToString(record.GetValue(variable)); }
                                if (variable.Name.Equals("r285x_6")) { r285x_6 = Convert.ToString(record.GetValue(variable)); }
                            }

                        }



                    }
                    if (u_id != null)
                    {

                        //iobj.insert_Dashboard_values(userID, gender, country, SURVEY_ID, weightage, SURVEY_PERIOD, BrTom, AdTom, favouriteBrand, bumo, location, AgeGroup, ses, AdSpontRomaKelapa, AdSpontRomaMalkist, AdSpontSlaiOLai, AdSpontRomaMarieSusu, AdSpontRomaMalkistAbon, AdSpontRomaSariGandumCokelat, AdSpontBiskuat, AdSpontBetter, AdSpontBiskuatCoklatSusu, AdSpontBiskuatEnergi, AdSpontBiskuatEnergiCoklat, AdSpontBiskuatSusu, AdSpontOreo, AdSpontSOLTwice, AdSpontRomaMalkistCoklat, AdSpontTwice, AdSpontBelvita, BrSpontRomaKelapa, BrSpontRomaMalkist, BrSpontSlaiOLai, BrSpontRomaMarieSusu, BrSpontRomaMalkistAbon, BrSpontRomaSariGandumCokelat, BrSpontBiskuat, BrSpontBetter, BrSpontBiskuatCoklatSusu, BrSpontBiskuatEnergi, BrSpontBiskuatEnergiCoklat, BrSpontBiskuatSusu, BrSpontOreo, BrSpontSOLTwice, BrSpontRomaMalkistCoklat, BrSpontTwice, BrSpontBelvita, BrAidRomaKelapa, BrAidRomaMalkist, BrAidSlaiOLai, BrAidRomaMarieSusu, BrAidRomaMalkistAbon, BrAidRomaSariGandumCokelat, BrAidBiskuat, BrAidBetter, BrAidBiskuatCoklatSusu, BrAidBiskuatEnergi, BrAidBiskuatEnergiCoklat, BrAidBiskuatSusu, BrAidOreo, BrAidSOLTwice, BrAidRomaMalkistCoklat, BrAidTwice, BrAidBelvita, AdAidRomaKelapa, AdAidRomaMalkist, AdAidSlaiOLai, AdAidRomaMarieSusu, AdAidRomaMalkistAbon, AdAidRomaSariGandumCokelat, AdAidBiskuat, AdAidBetter, AdAidBiskuatCoklatSusu, AdAidBiskuatEnergi, AdAidBiskuatEnergiCoklat, AdAidBiskuatSusu, AdAidOreo, AdAidSOLTwice, AdAidRomaMalkistCoklat, AdAidTwice, AdAidBelvita, CurConsRomaKelapa, CurConsRomaMalkist, CurConsSlaiOLai, CurConsRomaMarieSusu, CurConsRomaMalkistAbon, CurConsRomaSariGandumCokelat, CurConsBiskuat, CurConsBetter, CurConsBiskuatCoklatSusu, CurConsBiskuatEnergi, CurConsBiskuatEnergiCoklat, CurConsBiskuatSusu, CurConsOreo, CurConsSOLTwice, CurConsRomaMalkistCoklat, CurConsTwice, CurConsBelvita, ConsLMRomaKelapa, ConsLMRomaMalkist, ConsLMSlaiOLai, ConsLMRomaMarieSusu, ConsLMRomaMalkistAbon, ConsLMRomaSariGandumCokelat, ConsLMBiskuat, ConsLMBetter, ConsLMBiskuatCoklatSusu, ConsLMBiskuatEnergi, ConsLMBiskuatEnergiCoklat, ConsLMBiskuatSusu, ConsLMOreo, ConsLMSOLTwice, ConsLMRomaMalkistCoklat, ConsLMTwice, ConsLMBelvita, BrTomNetKhongGuan, BrTomNetRomaSariGandum, BrTomNetRomaCrackers, BrTomNetKGCrakers, BrTomNetSlaiOlai, BrSpontNetKhongGuan, BrSpontNetRomaSariGandum, BrSpontNetRomaCrackers, BrSpontNetKGCrakers, BrSpontNetSlaiOlai, BrAidNetKhongGuan, BrAidNetRomaSariGandum, BrAidNetRomaCrackers, BrAidNetKGCrakers, BrAidNetSlaiOlai, AdTomNetKhongGuan, AdTomNetRomaSariGandum, AdTomNetRomaCrackers, AdTomNetKGCrakers, AdTomNetSlaiOlai, AdSpontNetKhongGuan, AdSpontNetRomaSariGandum, AdSpontNetRomaCrackers, AdSpontNetKGCrakers, AdSpontNetSlaiOlai, AdAidNetKhongGuan, AdAidNetRomaSariGandum, AdAidNetRomaCrackers, AdAidNetKGCrakers, AdAidNetSlaiOlai, NetFavBrandKhongGuan, NetFavBrandRomaSariGandum, NetFavBrandRomaCrackers, NetFavBrandKGCrakers, NetFavBrandSlaiOlai, NetBumoKhongGuan, NetBumoRomaSariGandum, NetBumoRomaCrackers, NetBumoKGCrakers, NetBumoSlaiOlai, NetConsuLMKhongGuan, NetConsuLMRomaSariGandum, NetConsuLMRomaCrackers, NetConsuLMKGCrakers, NetConsuLMSlaiOlai, NetConCurKhongGuan, NetConCurRomaSariGandum, NetConCurRomaCrackers, NetConCurKGCrakers, NetConCurSlaiOlai, period, q146ft1_14, q146ft1_15, q146ft1_16, q146ft1_18, q146ft1_19, q146ft1_4, q146ft1_5, q146ft6_8, q146ft6_9, q146ft6_11, q146ft6_12, q146ft6_13, q146ft6_14, q146ft2_2, q146ft2_4, q146ft2_5, q146ft2_8, q146ft2_11, q146ft2_13, q146ft2_14, q146ft2_18, q146ft2_19, q146ft7_2, q146ft7_4, q146ft7_5, q146ft7_8, q146ft7_11, q146ft7_13, q146ft7_14, q146ft7_18, q146ft7_19, q146ft8_1, q146ft8_2, q146ft8_3, q146ft8_4, q146ft8_5, q146ft8_6, q146ft8_8, q146ft8_9, q146ft8_11, q146ft8_12, q146ft8_13, q146ft8_14, q146ft8_15, q146ft8_16, q146ft8_18, q146ft8_19, AsSpontBisvitSelimut, BrSpontBisvitSelimut, BrAidBisvitSelimut, AdAidBisvitSelimut, CurConsBisvitSelimut, ConsLMBisvitSelimut, BrTomNetHATARI, BrSpontNetHATARI, BrAidNetHATARI, AdTomNetHATARI, AdSpontNetHATARI, AdAidNetHATARI, NetFavBrandHATARI, NetBumoHATARI, NetConsuLMHATARI, NetConCurHATARI, q266t1_1, q266t1_2, q266t1_3, q266t1_4, q266t1_5, q266t2_1, q266t2_2, q266t2_3, q266t2_4, q266t2_5, q267t1_1, q267t1_2, q267t1_3, q267t1_4, q267t1_5, q267t1_6, q267t2_1, q267t2_2, q267t2_3, q267t2_4, q267t2_5, q267t2_6, q268t1_1, q268t1_2, q268t1_3, q268t1_4, q268t1_5, q268t2_1, q268t2_2, q268t2_3, q268t2_4, q268t2_5, q269t1_1, q269t1_2, q269t1_3, q269t1_4, q269t1_5, q269t2_1, q269t2_2, q269t2_3, q269t2_4, q269t2_5, q270t1_1, q270t1_2, q270t1_3, q270t1_4, q270t1_5, q270t1_6, q270t1_7, q270t2_1, q270t2_2, q270t2_3, q270t2_4, q270t2_5, q270t2_6, q270t2_7, q271t1_1, q271t1_2, q271t1_3, q271t1_4, q271t1_5, q271t1_6, q271t3_1, q271t3_2, q271t3_3, q271t3_4, q271t3_5, q271t3_6);
                        iobj.insert_Dashboard_values(userID, gender, country, SURVEY_ID, weightage, SURVEY_PERIOD, BrTom, AdTom, favouriteBrand, bumo, location, AgeGroup, ses, AdSpontRomaKelapa, AdSpontRomaMalkist, AdSpontSlaiOLai, AdSpontRomaMarieSusu, AdSpontRomaMalkistAbon, AdSpontRomaSariGandumCokelat, AdSpontBiskuat, AdSpontBetter, AdSpontBiskuatCoklatSusu, AdSpontBiskuatEnergi, AdSpontBiskuatEnergiCoklat, AdSpontBiskuatSusu, AdSpontOreo, AdSpontSOLTwice, AdSpontRomaMalkistCoklat, AdSpontTwice, AdSpontBelvita, BrSpontRomaKelapa, BrSpontRomaMalkist, BrSpontSlaiOLai, BrSpontRomaMarieSusu, BrSpontRomaMalkistAbon, BrSpontRomaSariGandumCokelat, BrSpontBiskuat, BrSpontBetter, BrSpontBiskuatCoklatSusu, BrSpontBiskuatEnergi, BrSpontBiskuatEnergiCoklat, BrSpontBiskuatSusu, BrSpontOreo, BrSpontSOLTwice, BrSpontRomaMalkistCoklat, BrSpontTwice, BrSpontBelvita, BrAidRomaKelapa, BrAidRomaMalkist, BrAidSlaiOLai, BrAidRomaMarieSusu, BrAidRomaMalkistAbon, BrAidRomaSariGandumCokelat, BrAidBiskuat, BrAidBetter, BrAidBiskuatCoklatSusu, BrAidBiskuatEnergi, BrAidBiskuatEnergiCoklat, BrAidBiskuatSusu, BrAidOreo, BrAidSOLTwice, BrAidRomaMalkistCoklat, BrAidTwice, BrAidBelvita, AdAidRomaKelapa, AdAidRomaMalkist, AdAidSlaiOLai, AdAidRomaMarieSusu, AdAidRomaMalkistAbon, AdAidRomaSariGandumCokelat, AdAidBiskuat, AdAidBetter, AdAidBiskuatCoklatSusu, AdAidBiskuatEnergi, AdAidBiskuatEnergiCoklat, AdAidBiskuatSusu, AdAidOreo, AdAidSOLTwice, AdAidRomaMalkistCoklat, AdAidTwice, AdAidBelvita, CurConsRomaKelapa, CurConsRomaMalkist, CurConsSlaiOLai, CurConsRomaMarieSusu, CurConsRomaMalkistAbon, CurConsRomaSariGandumCokelat, CurConsBiskuat, CurConsBetter, CurConsBiskuatCoklatSusu, CurConsBiskuatEnergi, CurConsBiskuatEnergiCoklat, CurConsBiskuatSusu, CurConsOreo, CurConsSOLTwice, CurConsRomaMalkistCoklat, CurConsTwice, CurConsBelvita, ConsLMRomaKelapa, ConsLMRomaMalkist, ConsLMSlaiOLai, ConsLMRomaMarieSusu, ConsLMRomaMalkistAbon, ConsLMRomaSariGandumCokelat, ConsLMBiskuat, ConsLMBetter, ConsLMBiskuatCoklatSusu, ConsLMBiskuatEnergi, ConsLMBiskuatEnergiCoklat, ConsLMBiskuatSusu, ConsLMOreo, ConsLMSOLTwice, ConsLMRomaMalkistCoklat, ConsLMTwice, ConsLMBelvita, BrTomNetKhongGuan, BrTomNetRomaSariGandum, BrTomNetRomaCrackers, BrTomNetKGCrakers, BrTomNetSlaiOlai, BrSpontNetKhongGuan, BrSpontNetRomaSariGandum, BrSpontNetRomaCrackers, BrSpontNetKGCrakers, BrSpontNetSlaiOlai, BrAidNetKhongGuan, BrAidNetRomaSariGandum, BrAidNetRomaCrackers, BrAidNetKGCrakers, BrAidNetSlaiOlai, AdTomNetKhongGuan, AdTomNetRomaSariGandum, AdTomNetRomaCrackers, AdTomNetKGCrakers, AdTomNetSlaiOlai, AdSpontNetKhongGuan, AdSpontNetRomaSariGandum, AdSpontNetRomaCrackers, AdSpontNetKGCrakers, AdSpontNetSlaiOlai, AdAidNetKhongGuan, AdAidNetRomaSariGandum, AdAidNetRomaCrackers, AdAidNetKGCrakers, AdAidNetSlaiOlai, NetFavBrandKhongGuan, NetFavBrandRomaSariGandum, NetFavBrandRomaCrackers, NetFavBrandKGCrakers, NetFavBrandSlaiOlai, NetBumoKhongGuan, NetBumoRomaSariGandum, NetBumoRomaCrackers, NetBumoKGCrakers, NetBumoSlaiOlai, NetConsuLMKhongGuan, NetConsuLMRomaSariGandum, NetConsuLMRomaCrackers, NetConsuLMKGCrakers, NetConsuLMSlaiOlai, NetConCurKhongGuan, NetConCurRomaSariGandum, NetConCurRomaCrackers, NetConCurKGCrakers, NetConCurSlaiOlai, period, q146ft1_14, q146ft1_15, q146ft1_16, q146ft1_18, q146ft1_19, q146ft1_4, q146ft1_5, q146ft6_8, q146ft6_9, q146ft6_11, q146ft6_12, q146ft6_13, q146ft6_14, q146ft2_2, q146ft2_4, q146ft2_5, q146ft2_8, q146ft2_11, q146ft2_13, q146ft2_14, q146ft2_18, q146ft2_19, q146ft7_2, q146ft7_4, q146ft7_5, q146ft7_8, q146ft7_11, q146ft7_13, q146ft7_14, q146ft7_18, q146ft7_19, q146ft8_1, q146ft8_2, q146ft8_3, q146ft8_4, q146ft8_5, q146ft8_6, q146ft8_8, q146ft8_9, q146ft8_11, q146ft8_12, q146ft8_13, q146ft8_14, q146ft8_15, q146ft8_16, q146ft8_18, q146ft8_19, AsSpontBisvitSelimut, BrSpontBisvitSelimut, BrAidBisvitSelimut, AdAidBisvitSelimut, CurConsBisvitSelimut, ConsLMBisvitSelimut, BrTomNetHATARI, BrSpontNetHATARI, BrAidNetHATARI, AdTomNetHATARI, AdSpontNetHATARI, AdAidNetHATARI, NetFavBrandHATARI, NetBumoHATARI, NetConsuLMHATARI, NetConCurHATARI, q266t1_1, q266t1_2, q266t1_3, q266t1_4, q266t1_5, q266t2_1, q266t2_2, q266t2_3, q266t2_4, q266t2_5, q267t1_1, q267t1_2, q267t1_3, q267t1_4, q267t1_5, q267t1_6, q267t2_1, q267t2_2, q267t2_3, q267t2_4, q267t2_5, q267t2_6, q268t1_1, q268t1_2, q268t1_3, q268t1_4, q268t1_5, q268t2_1, q268t2_2, q268t2_3, q268t2_4, q268t2_5, q269t1_1, q269t1_2, q269t1_3, q269t1_4, q269t1_5, q269t2_1, q269t2_2, q269t2_3, q269t2_4, q269t2_5, q270t1_1, q270t1_2, q270t1_3, q270t1_4, q270t1_5, q270t1_6, q270t1_7, q270t2_1, q270t2_2, q270t2_3, q270t2_4, q270t2_5, q270t2_6, q270t2_7, q271t1_1, q271t1_2, q271t1_3, q271t1_4, q271t1_5, q271t1_6, q271t3_1, q271t3_2, q271t3_3, q271t3_4, q271t3_5, q271t3_6, ConsP1WRomaKelapa, ConsP1WRomaMalkist, ConsP1WSlaiOLai, ConsP1WRomaMarieSusu, ConsP1WRomaMalkistAbon, ConsP1WRomaSariGandumCokelat, ConsP1WBiskuat, ConsP1WBetter, ConsP1WBiskuatCoklatSusu, ConsP1WBiskuatEnergi, ConsP1WBiskuatEnergiCoklat, ConsP1WBiskuatSusu, ConsP1WOreo, ConsP1WSOLTwice, ConsP1WRomaMalkistCoklat, ConsP1WTwice, ConsP1WBelvita, ConsP1WBisvitSelimut, ConsP1DRomaKelapa, ConsP1DRomaMalkist, ConsP1DSlaiOLai, ConsP1DRomaMarieSusu, ConsP1DRomaMalkistAbon, ConsP1DRomaSariGandumCokelat, ConsP1DBiskuat, ConsP1DBetter, ConsP1DBiskuatCoklatSusu, ConsP1DBiskuatEnergi, ConsP1DBiskuatEnergiCoklat, ConsP1DBiskuatSusu, ConsP1DOreo, ConsP1DSOLTwice, ConsP1DRomaMalkistCoklat, ConsP1DTwice, ConsP1DBelvita, ConsP1DBisvitSelimut, r284x_7, r284x_13, r284x_19, r284x_20, r284x_25, r284x_6, r285x_7, r285x_13, r285x_19, r285x_20, r285x_25, r285x_6);

                        // Console.Write('\t');

                    }
    
                }
            }
        }
        static string find_UserId(int id, string period, string sp_id)
        {
            string sum = "";
            string[] date = period.Split('-');
            foreach (string d in date)
            {
                sum = sum + d;

            }
            return sp_id + id + sum;
        }
    }
}
