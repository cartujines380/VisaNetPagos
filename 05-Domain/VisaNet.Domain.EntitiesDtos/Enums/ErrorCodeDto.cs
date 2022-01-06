﻿namespace VisaNet.Domain.EntitiesDtos.Enums
{
    public enum ErrorCodeDto
    {
        OK = 0,
        ERROR_GENERAL = 1,
        ERRORES_EN_LOS_CAMPOS_ENVIADOS = 2,
        CAMPO_OBLIGATORIO_NO_ENVIADO = 3,
        CAMPO_EXCEDE_EL_LARGO_MAXIMO = 4,
        CAMPO_CON_VALOR_NEGATIVO = 5,
        CAMPO_FECHA_NO_TIENE_VALOR_VALIDO = 6,
        FACTURA_YA_INGRESADA_EN_EL_SISTEMA = 7,
        FACTURA_YA_PAGA_EN_EL_SISTEMA = 8,
        CAMPO_NO_CONCUERDA_CON_LOS_DATOS_ENVIADOS = 10,
        ID_OPERACION_REPETIDO = 11,
        FIRMA_INVALIDA = 12,
        CERTIFICADO_NO_ENCONTRADO = 13,
        MATRICULA_SIN_SERVICIO_ASOCIADO = 50,
        SERVICIO_SIN_TARJETA_PARA_PAGAR = 51,
        SERVICIO_SIN_TOKEN_PARA_PAGAR = 52,
        SERVICIO_CON_TARJETA_VENCIDA = 53,
        ERROR_AL_INENTAR_GUARDAR_LA_TRANSACCION = 54,
        ERROR_AL_INENTAR_GENERAR_LA_TRANSACCION = 55,
        NO_SE_ENCONTRO_LA_OPERACION = 60,
        NO_SE_ENCONTRO_LA_TRANSACCION = 61,
        OPERACION_YA_REALIZADA = 62,
        USUARIO_NO_ENCONTRADO = 63,
        TARJETA_NO_ENCONTRADA = 64,
        EL_BIN_DE_LA_FACTURA_NO_SE_CORRESPONDE_CON_LOS_DATOS_DE_LA_TARJETA_INGRESADOS = 70,
        NO_SE_INGRESO_NINGUNA_FACTURA_A_PAGAR = 71,
        LAS_FACTURAS_A_PAGAR_DEBEN_SER_DEL_MISMO_SERVICIO = 72,
        LAS_FACTURAS_A_PAGAR_DEBEN_SER_DE_LA_MISMA_PASARELA = 73,
        LAS_FACTURAS_A_PAGAR_DEBEN_TENER_EL_MISMO_BIN = 74,
        LA_PASARELA_INGRESADA_NO_ESTA_ASOCIADA_AL_SERVICIO = 75,
        LAS_FACTURAS_A_PAGAR_DEBEN_TENER_EL_MISMO_ID_PADRON = 76,
        ERROR_DE_LA_PASARELA_SUCIVE_O_GEOCOM = 77,
        ERROR_DE_LA_PASARELA = 78,
        EL_TIEMPO_DE_RESPUESTA_DE_LA_PASARELA_SUPERO_EL_TIEMPO_DE_ESPERA_DEFINIDO = 79,
        ERROR_GENERAL_LUEGO_DE_REALIZADO_EL_PAGO_O_REVERSO_DE_LA_TRANSACCION = 99,
        CYBERSOURCE_OK = 100,
        ERROR_DE_CAMPOS = 102,
        ERROR_DE_BANCO = 150,
        TARJETA_VENCIDA = 202,
        FONDOS_INSUFICIENTES = 204,
        TARJETA_DECLARADA_COMO_ROBADA_O_PERDIDA = 205,
        TARJETA_INACTIVA_O_NO_AUTORIZADA = 208,
        LIMITE_DE_CREDITO_EXCEDIDO = 210,
        CVV_INVALIDO = 211,
        CUENTA_CONGELADA = 222,
        NUMERO_DE_CUENTA_INVALIDO = 231,
        EL_TIPO_DE_TARJETA_NO_ES_ACEPTADA_POR_EL_PROCESADOR = 232,
        EL_TIPO_DE_TARJETA_ES_INVALIDO_O_NO_CORREPSONDE_CON_EL_NRO_DE_CUENTA = 240,
        AUTORIZACION_ACEPTADA_Y_DECLINADA_POR_CYBERSOURCE_CVV_CHECK = 230,
        ERROR_DE_KEYS = 104,
        AUTORIZACION_ACEPTADA_Y_RECHAZADA_POR_CYBERSOURCE_POR_NO_PASAR_EL_AVS = 200,
        AUTORIZACION_AUTOMATICA_RECHAZADA = 201,
        //ERROR_DE_BANCO = 207,
        NEGACION_GENERAL = 233,
        ERROR_EN_DATOS_DEL_USUARIO_EN_CYBERSOURCE = 234,
        ERROR_GENERAL_DEL_PROCESADOR = 236,
        PAYER_AUTHENTICATION_ERROR = 475,
        //PAYER_AUTHENTICATION_ERROR = 476,
        DECISIONMANAGER = 481,
        AUTORIZACION_ACEPTADA_Y_DECLINADA_POR_CYBERSOURCE = 520
    }
}