using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Console;
using WindowsForms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Parameter parameter = new Parameter();

        public Form1()
        {
            InitializeComponent();
            initialize();
        }

        private void initialize()
        {
            this.CmbTribe.SelectedItem = "スライム";
            this.CmbPopPosition.SelectedItem = "草原";
            this.CmbAttackKindFirst.SelectedItem = "魔法";
            this.CmbAttackKindSecond.SelectedItem = "魔法";
            this.CmbAttackKindThird.SelectedItem = "魔法";
            this.CmbAttackKindFourth.SelectedItem = "魔法";
        }

        private string GetMonsterName()
        {
            string textValue = this.TextMonsterName.Text;
            return textValue;
        }

        private WindowsForms.Attribute GetAttribute()
        {
            if (this.RbtFire.Checked == true)
            {
                return WindowsForms.Attribute.fire;
            }
            else if (this.RbtWind.Checked == true)
            {
                return WindowsForms.Attribute.water;
            }
            else if (this.RbtThunder.Checked == true)
            {
                return WindowsForms.Attribute.thunder;
            }
            else if (this.RbtSoil.Checked == true)
            {
                return WindowsForms.Attribute.soil;
            }
            else if (this.RbtWind.Checked == true)
            {
                return WindowsForms.Attribute.wind;
            }

            return 0;
        }

        private int GetLevel()
        {
            return (int)this.NudLevel.Value;
        }

        private int GetExperience()
        {
            return (int)this.NudExperience.Value;
        }

        private string GetPopPosition()
        {
            return this.CmbPopPosition.SelectedItem.ToString();
        }

        private string GetMonsterKind()
        {
            return this.CmbTribe.SelectedItem.ToString();
        }

        private List<string> GetCommandNameList()
        {
            return new List<string> { this.TextCommandFirst.Text, this.TextCommandSecond.Text, this.TextCommandThird.Text, this.TextCommandFourth.Text };
        }

        private List<int> GetCommandAttackPowerList()
        {
            return new List<int> { (int)this.NudPowerFirst.Value, (int)this.NudPowerSecond.Value, (int)this.NudPowerThird.Value, (int)this.NudPowerFourth.Value };
        }

        private List<string> GetCommandAttackKindList()
        {
            return new List<string> { this.CmbAttackKindFourth.SelectedItem.ToString(), this.CmbAttackKindSecond.SelectedItem.ToString(), this.CmbAttackKindThird.SelectedItem.ToString(), this.CmbAttackKindFourth.SelectedItem.ToString() };
        }

        private void SetCommandName()
        {
            var name_list = GetCommandNameList();
            this.parameter.CommandFirstName = name_list[0];
            this.parameter.CommandSecondName = name_list[1];
            this.parameter.CommandThirdName = name_list[2];
            this.parameter.CommandFourthName = name_list[3];
        }

        private void SetCommandAttackPower()
        {
            var power_list = GetCommandAttackPowerList();
            this.parameter.CommandFirstPower = power_list[0];
            this.parameter.CommandSecondPower = power_list[1];
            this.parameter.CommandThirdPower = power_list[2];
            this.parameter.CommandFourthPower = power_list[3];
        }

        private AttackKind CheckASttackKind(string kind)
        {
            var select_kind = kind switch
            {
                "魔法" => AttackKind.magic,
                "物理" => AttackKind.physical,
                _ => AttackKind.unknown
            };

            return select_kind;
        }

        private void SetCommandAttackKind()
        {
            var kind_list = GetCommandAttackKindList();
            this.parameter.CommandFirstKind = CheckASttackKind(kind_list[0]);
            this.parameter.CommandSecondKind = CheckASttackKind(kind_list[1]);
            this.parameter.CommandThirdKind = CheckASttackKind(kind_list[2]);
            this.parameter.CommandFourthKind = CheckASttackKind(kind_list[3]);
        }

        private void SetMaxAttackPower()
        {
            var power_list = GetCommandAttackPowerList();
            this.parameter.MaxAttackPower = power_list.Max();
        }

        private void SetParameter()
        {
            // モンスター名
            this.parameter.MonsterName = GetMonsterName();

            // 属性
            this.parameter.Attribute = GetAttribute();

            // レベル
            this.parameter.Level = GetLevel();

            // 経験値
            this.parameter.Experience = GetExperience();

            // 種族
            this.parameter.MonsterTribe = GetMonsterKind() switch
            {
                "スライム" => Tribe.slime,
                "ドラゴン" => Tribe.dragon,
                "幽霊" => Tribe.ghost,
                "獣" => Tribe.beast,
            };

            // 出現場所
            this.parameter.Position = GetPopPosition() switch
            {
                "草原" => PopPosition.grass_field,
                "洞窟" => PopPosition.cave,
                "森" => PopPosition.forest,
            };

            SetCommandName();

            SetCommandAttackPower();

            SetCommandAttackKind();

            SetMaxAttackPower();
        }

        private void BtnComplete_Click(object sender, EventArgs e)
        {
            SetParameter();

            // シリアライズ先のファイル
            const string xmlFile = @".\MonsterParameter.xml";
            // シリアライズするオブジェクト
            var obj = this.parameter;

            // シリアライズする
            var xmlSerializer1 = new XmlSerializer(typeof(Parameter));
            using (var streamWriter = new StreamWriter(xmlFile, false, Encoding.UTF8))
            {
                xmlSerializer1.Serialize(streamWriter, obj);
                streamWriter.Flush();
            }

        }

        private void BtnAppealPoint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("自身で軽いRPGを作成する際に使えるような形で作成しました","アピールポイント");
        }
    }
}

