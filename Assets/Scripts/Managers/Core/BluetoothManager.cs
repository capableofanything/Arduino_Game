using System;
using System.Collections;
using System.Collections.Generic;
using ArduinoBluetoothAPI;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BluetoothManager
{

    BluetoothHelper bluetoothHelper;

    private bool onConnected = false;
    private bool connectedFailed = false;
	private string deviceName;
    private string[] presentdata;
    private string received_message;
    private Vector3 rot = Vector3.zero;

    public bool GetOnConnected() { return onConnected; }
    public bool GetConnectedFailed() { return connectedFailed; }
	public Vector3 GetData() { return rot; }
	public float GetX() { return rot.x; }
	public float GetY() { return rot.y; }
	public float GetZ() { return rot.z; }
    public void Connect()
    {
        Init();
        connectedFailed = false;
        if (bluetoothHelper.isDevicePaired())
        {
            Debug.Log("try to connect");
            bluetoothHelper.Connect(); // tries to connect
        }
        else
        {
            Debug.Log("not DevicePaired");
        }
    }

    public void DisConnect()
    {
        onConnected = false;
        bluetoothHelper.Disconnect();
        Debug.Log("DisConnected");
    }
    public void Clear()
    {
        rot = Vector3.zero;
        received_message= string.Empty;
        presentdata= null;
    }


	private void OnMessageReceived () 
	{
		received_message = bluetoothHelper.Read();
        presentdata = received_message.Split(',');
		if(presentdata.Length>2)       
			rot = new Vector3(float.Parse(presentdata[1]), float.Parse(presentdata[2]), 0f);
    }
    private void Init()
    {
        deviceName = "HC-07";

        try
        {
            bluetoothHelper = BluetoothHelper.GetInstance(deviceName);
            bluetoothHelper.OnConnected += OnConnected;
            bluetoothHelper.OnConnectionFailed += OnConnectionFailed;
            bluetoothHelper.OnDataReceived += OnMessageReceived; //read the data
            bluetoothHelper.setTerminatorBasedStream("\n");

            if (bluetoothHelper.isDevicePaired())
            {
                Debug.Log("Paired");
            }
            else
                Debug.Log("Unpaired");
        }
        catch (Exception ex)
        {
            Debug.Log("Disconnected");
            Debug.Log(ex.Message);
        }
    }
    private void OnConnected () 
	{
		try 
		{
			bluetoothHelper.StartListening ();
			Debug.Log ("Connected");
            onConnected = true;
            connectedFailed = false;
        } 
		catch (Exception ex) 
		{
			Debug.Log (ex.Message);
		}
	}

	private void OnConnectionFailed () 
	{
		Debug.Log ("Connection Failed");
        connectedFailed= true;
	}
}