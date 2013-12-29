class IVA(object):
    """Definicion del IVA """
    def __init__(self, alicuota=0.21):
        self.__descripcion = 'Impuesto al Valor agregado'
        self.__alicuota = alicuota
        
    def CalcularIVA(self,importe):
        """ Es el valor de la alicuota por el valor que se le indica en el calculo"""
        return importe * self.__alicuota

    def getAlicuota(self):
        return self.__alicuota
    
    def setAlicuota(self, valor):
        self.__alicuota = valor
    

