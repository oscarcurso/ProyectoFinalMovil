using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerPPref : MonoBehaviour {

    private const string XPOS = "xPos";
    private const string YPOS = "yPos";
    private const string ZPOS = "zPos";
    private const string PUNTOS = "puntos";
    private const string VIDAS = "vidas";

    public static void StorePosition(Vector3 position) {

        PlayerPrefs.SetFloat(XPOS, position.x);
        PlayerPrefs.SetFloat(YPOS, position.y);
        PlayerPrefs.SetFloat(ZPOS, position.z);
       

    }

    public static void StorePuntos(int puntos) {
        PlayerPrefs.SetInt(PUNTOS, puntos);
    }

    public static void StoreVidas(int vidas)
    {
        PlayerPrefs.SetInt(VIDAS, vidas);
    }

    public static Vector3 GetPosition() {
        Vector3 position = new Vector3();

        if (PlayerPrefs.HasKey(XPOS) && PlayerPrefs.HasKey(YPOS) && PlayerPrefs.HasKey(ZPOS)) {
            float x = PlayerPrefs.GetFloat(XPOS);
            float y = PlayerPrefs.GetFloat(YPOS);
            float z = PlayerPrefs.GetFloat(ZPOS);
            position = new Vector3(x, y,z);


        } else {
            position = Vector3.zero;
        }
        return position;

    }

    public static int GetPuntos() {
        int puntuacion = 0;
        if (PlayerPrefs.HasKey(PUNTOS)){
            puntuacion = PlayerPrefs.GetInt(PUNTOS);
        }

        return puntuacion;
    }

    public static int GetVidas()
    {
        int vidas = 0;
        if (PlayerPrefs.HasKey(VIDAS))
        {
            vidas = PlayerPrefs.GetInt(VIDAS);
        }
        return vidas;
    }
}
