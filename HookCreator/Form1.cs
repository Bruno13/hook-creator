/*
	Hook Creator(Criador de Hook)
		- Simplifica o trabalho para criar o hook (method ALS 7) de uma
        callback, oferecendo a lista de todas as callbacks do SA-MP com
        todos seus parâmetros. Também disponibiliza a opção para separar
        as partes do hook para fácil manejo.

		Versão: 1.0.0
		Última atualização: 30/12/2017

	Copyright (C) 2017 Bruno "Bruno13" Travi.

	This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.

	Esqueleto do código:
	|
	 *
	 * LIBRARIES
	 *
	|
	 *
	 * ARRAYS
	 *
	|
	 *
	 * CALLBACKS
	 *
	|
	 *
	 * EVENTS
	 *
	|
*/
/*
 * LIBRARIES
 ******************************************************************************
 */
using System;
using System.Windows.Forms;

namespace HookCreator
{
    public partial class Form1 : Form
    {
        /*
         * ARRAYS
         ******************************************************************************
         */
        string[] callbacks = new string[]
        {
            "OnActorStreamIn",
            "OnActorStreamOut",
            "OnClientMessage",
            "OnDialogResponse",
            "OnEnterExitModShop",
            "OnFilterScriptExit",
            "OnFilterScriptInit",
            "OnGameModeExit",
            "OnGameModeInit",
            "OnIncomingConnection",
            "OnObjectMoved",
            "OnPlayerClickMap",
            "OnPlayerClickPlayer",
            "OnPlayerClickPlayerTextDraw",
            "OnPlayerClickTextDraw",
            "OnPlayerCommandText",
            "OnPlayerConnect",
            "OnPlayerDeath",
            "OnPlayerDisconnect",
            "OnPlayerEditAttachedObject",
            "OnPlayerEditObject",
            "OnPlayerEnterCheckpoint",
            "OnPlayerEnterRaceCheckpoint",
            "OnPlayerEnterVehicle",
            "OnPlayerExitVehicle",
            "OnPlayerExitedMenu",
            "OnPlayerGiveDamage",
            "OnPlayerGiveDamageActor",
            "OnPlayerInteriorChange",
            "OnPlayerKeyStateChange",
            "OnPlayerLeaveCheckpoint",
            "OnPlayerLeaveRaceCheckpoint",
            "OnPlayerObjectMoved",
            "OnPlayerPickUpPickup",
            "OnPlayerRequestClass",
            "OnPlayerRequestSpawn",
            "OnPlayerSelectObject",
            "OnPlayerSelectedMenuRow",
            "OnPlayerSpawn",
            "OnPlayerStateChange",
            "OnPlayerStreamIn",
            "OnPlayerStreamOut",
            "OnPlayerTakeDamage",
            "OnPlayerText",
            "OnPlayerUpdate",
            "OnPlayerWeaponShot",
            "OnRconCommand",
            "OnRconLoginAttempt",
            "OnRecordingPlaybackEnd",
            "OnTrailerUpdate",
            "OnUnoccupiedVehicleUpdate",
            "OnVehicleDamageStatusUpdate",
            "OnVehicleDeath",
            "OnVehicleMod",
            "OnVehiclePaintjob",
            "OnVehicleRespray",
            "OnVehicleSirenStateChange",
            "OnVehicleSpawn",
            "OnVehicleStreamIn",
            "OnVehicleStreamOut"
        },

        callbacksParams = new string[]
        {
            "(actorid, forplayerid)",
            "(actorid, forplayerid)",
            "(color, text[])",
            "(playerid, dialogid, response, listitem, inputtext[])",
            "(playerid, enterexit, interiorid)",
            "()",
            "()",
            "()",
            "()",
            "(playerid, ip_address[], port)",
            "(objectid)",
            "(playerid, Float:fX, Float:fY, Float:fZ)",
            "(playerid, clickedplayerid, source)",
            "(playerid, PlayerText:playertextid)",
            "(playerid, Text:clickedid)",
            "(playerid, cmdtext[])",
            "(playerid)",
            "(playerid, killerid, reason)",
            "(playerid, reason)",
            "(playerid, response, index, modelid, boneid, Float:fOffsetX, Float:fOffsetY, Float:fOffsetZ, Float:fRotX, Float:fRotY, Float:fRotZ, Float:fScaleX, Float:fScaleY, Float:fScaleZ)",
            "(playerid, playerobject, objectid, response, Float:fX, Float:fY, Float:fZ, Float:fRotX, Float:fRotY, Float:fRotZ)",
            "(playerid)",
            "(playerid)",
            "(playerid, vehicleid, ispassenger)",
            "(playerid, vehicleid)",
            "(playerid)",
            "(playerid, damagedid, Float:amount, weaponid, bodypart)",
            "(playerid, damaged_actorid, Float:amount, weaponid, bodypart)",
            "(playerid, newinteriorid, oldinteriorid)",
            "(playerid, newkeys, oldkeys)",
            "(playerid)",
            "(playerid)",
            "(playerid, objectid)",
            "(playerid, pickupid)",
            "(playerid, classid)",
            "(playerid)",
            "(playerid, type, objectid, modelid, Float:fX, Float:fY, Float:fZ)",
            "(playerid, row)",
            "(playerid)",
            "(playerid, newstate, oldstate)",
            "(playerid, forplayerid)",
            "(playerid, forplayerid)",
            "(playerid, issuerid, Float:amount, weaponid, bodypart)",
            "(playerid, text[])",
            "(playerid)",
            "(playerid, weaponid, hittype, hitid, Float:fX, Float:fY, Float:fZ)",
            "(cmd[])",
            "(ip[], password[], success)",
            "()",
            "(playerid, vehicleid)",
            "(vehicleid, playerid, passenger_seat, Float:new_x, Float:new_y, Float:new_z, Float:vel_x, Float:vel_y, Float:vel_z)",
            "(vehicleid, playerid)",
            "(vehicleid, killerid)",
            "(playerid, vehicleid, componentid)",
            "(playerid, vehicleid, paintjobid)",
            "(playerid, vehicleid, color1, color2)",
            "(playerid, vehicleid, newstate)",
            "(vehicleid)",
            "(vehicleid, forplayerid)",
            "(vehicleid, forplayerid)"
        },
            
        charParamsRemove = new string[]
        {
            "[]",
            "Float:"
        };

        string hookAllFormat = "public Function(Args)\r\n{\r\n\t#if defined Prefix_Function\r\n\t\tPrefix_Function(Args2);\r\n\t#endif\r\n}\r\n#if defined _ALS_Function\r\n\t#undef Function\r\n#else\r\n\t#define _ALS_Function\r\n#endif\r\n#define Function Prefix_Function\r\n#if defined Prefix_Function\r\n\tforward Prefix_Function(Args);\r\n#endif";
        string hookALSFormat = "#if defined _ALS_Function\r\n\t#undef Function\r\n#else\r\n\t#define _ALS_Function\r\n#endif\r\n#define Function Prefix_Function\r\n#if defined Prefix_Function\r\n\tforward Prefix_Function(Args);\r\n#endif";
        string hookChainFormat = "\t#if defined Prefix_Function\r\n\t\tPrefix_Function(Args2);\r\n\t#endif";
        string hookCallChainFormat = "public Function(Args)\r\n{\r\n\t#if defined Prefix_Function\r\n\t\tPrefix_Function(Args2);\r\n\t#endif\r\n}";
        string hookAllFormatCompALS = "public Function(Args)\r\n{\r\n\t#if defined Prefix_Function\r\n\t\tPrefix_Function(Args2);\r\n\t#endif\r\n}\r\n#if defined ALS_Function\r\n\t#undef Function\r\n#else\r\n\t#define ALS_Function\r\n#endif\r\n#define Function Prefix_Function\r\n#if defined Prefix_Function\r\n\tforward Prefix_Function(Args);\r\n#endif";
        string hookALSFormatCompALS = "#if defined ALS_Function\r\n\t#undef Function\r\n#else\r\n\t#define ALS_Function\r\n#endif\r\n#define Function Prefix_Function\r\n#if defined Prefix_Function\r\n\tforward Prefix_Function(Args);\r\n#endif";
        
        /*
         * CALBLACKS
         ******************************************************************************
         */
        public Form1()
        {
            InitializeComponent();

            LoadCheckBoxCallbacks();

            radioButtonAll.Checked = true;
            radioButtonALS.Checked = radioButtonChain.Checked = radioButtonCallChain.Checked = false;

            Select();
        }

        /// <summary>
        /// Insere todas as callbacks da matriz 'callbacks' nos itens do comboBoxCallbacks.
        /// <returns>Não retorna valores.</returns>
        /// </summary>
        private void LoadCheckBoxCallbacks()
        {
            for (int i = 0; i < callbacks.Length; i++)
                comboBoxCallbacks.Items.Add(callbacks[i]);

            comboBoxCallbacks.SelectedIndex = 0;
        }

        /// <summary>
        /// Cria o hook e insere o resultado na textBoxResult.
        /// <param name="warnErrors">Se true, avisa erros de preenchimento do textBoxHookPrefix.</param>
        /// <returns>Não retorna valores.</returns>
        /// </summary>
        private void CreateHookResult(bool warnErrors = false)
        {
            int maxChar = 0;

            if (textBoxHookPrefix.Text == "")
            {
                if (warnErrors)
                    MessageBox.Show("Field Hook Prefix empty!");

                return;
            }
            else if (!IsValidHookPrefix(textBoxHookPrefix.Text, ref maxChar))
            {
                if (warnErrors)
                    MessageBox.Show((string.Format("Hook Prefix can't be longer than {0} characters!", maxChar)));

                return;
            }

            int callbackSelected = comboBoxCallbacks.SelectedIndex, indexChar;

            bool isALSComp = (callbacks[callbackSelected].Length > 26);

            string output, callParams;

            if (radioButtonAll.Checked)
                output = (isALSComp) ? (hookAllFormatCompALS) : (hookAllFormat);
            else if (radioButtonALS.Checked)
                output = (isALSComp) ? (hookALSFormatCompALS) : (hookALSFormat);
            else if (radioButtonChain.Checked)
                output = hookChainFormat;
            else
                output = hookCallChainFormat;

            callParams = callbacksParams[callbackSelected];

            indexChar = callParams.IndexOf(charParamsRemove[0]);

            while (indexChar != -1)
            {
                indexChar = callParams.IndexOf(charParamsRemove[0]);

                if (indexChar != -1)
                {
                    try
                    {
                        callParams = callParams.Remove(indexChar, 2);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + Environment.NewLine + ex.InnerException, "Error to Create Hook");
                    }
                }
            }

            indexChar = callParams.IndexOf(charParamsRemove[1]);

            while (indexChar != -1)
            {
                indexChar = callParams.IndexOf(charParamsRemove[1]);

                if (indexChar != -1)
                {
                    try
                    {
                        callParams = callParams.Remove(indexChar, 6);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + Environment.NewLine + ex.InnerException, "Error to Create Hook");
                    }
                }
            }

            output = output.Replace("Function", callbacks[callbackSelected]);

            output = output.Replace("(Args)", callbacksParams[callbackSelected]);

            output = output.Replace("(Args2)", callParams);

            output = output.Replace("Prefix", textBoxHookPrefix.Text);

            textBoxResult.Text = output.ToString();
        }

        /// <summary>
        /// Valida prefixo de hook específico é válido.
        /// <param name="prefix">Prefixo do hook.</param>
        /// <param name="maxChar">Variável para referenciada o máximo de caracteres que o prefixo pode ter para callback selecionada.</param>
        /// <returns>True se for válido, False se não.</returns>
        /// </summary>
        private bool IsValidHookPrefix(string prefix, ref int maxChar)
        {
            int callbackSelected = comboBoxCallbacks.SelectedIndex,
                callbackNameSize = callbacks[callbackSelected].Length + 1;//+1 = _

            maxChar = 31 - callbackNameSize;

            return ((prefix.Length + callbackNameSize) <= 31);
        }

        /*
         * EVENTS
         ******************************************************************************
         */
        private void buttonMakeHook_Click(object sender, System.EventArgs e)
        {
            CreateHookResult(true);
        }

        private void buttonCopyResult_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text != "")
                Clipboard.SetText(textBoxResult.Text);
        }

        private void textBoxResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                if (sender != null)
                {
                    ((TextBox)sender).SelectAll();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void textBoxHookPrefix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                CreateHookResult(true);
                e.Handled = true;
            }
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            CreateHookResult();
        }

        private void radioButtonALS_CheckedChanged(object sender, EventArgs e)
        {
            CreateHookResult();
        }

        private void radioButtonChain_CheckedChanged(object sender, EventArgs e)
        {
            CreateHookResult();
        }

        private void radioButtonCallChain_CheckedChanged(object sender, EventArgs e)
        {
            CreateHookResult();
        }
    }
}
