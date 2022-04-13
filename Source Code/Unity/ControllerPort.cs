using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEngine.Serialization;

public class ControllerPort : MonoBehaviour
{
    [SerializeField] private string portName = "COM3";
    [SerializeField] private int baudRate = 9600;

    private SerialPort _serialPort;

    private void Start()
    {
        _serialPort = new SerialPort("/" + portName, baudRate);
        _serialPort.Open();
    }
}
