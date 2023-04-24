from re import A


class Computador:
    def __init__(self,marca,memoria_ram,placa_video):
        self.Marca = marca
        self.MemoriaRam = memoria_ram
        self.PlacaDeVideo = placa_video
    pass

cpu = Computador('AA',56,'Integrada')
print(cpu.Marca,cpu.MemoriaRam,cpu.PlacaDeVideo)
#imc 
def IMC(peso,altura):
    return (peso/(altura**2))
def CImc(valor):
    if(valor<18.5):
        print('Está Magro!\n')
        print('Nível de obesidade = 0\n')
    elif(valor>=18.5 and valor<=24.9):
        print('Está Normal!\n')
        print('Nível de obesidade = 0\n')
    elif(valor>=25 and valor<=29.9):
        print('Está Sobrepeso!\n')
        print('Nível de obesidade = 1\n')
    elif(valor>=30 and valor<=39.9):
        print('Está Obeso!\n')
        print('Nível de obesidade = 2\n')
    elif(valor>=40):
        print('Está Uma grande Baleia!\n')
        print('Nível de obesidade = 3\n')


CImc(IMC(72.2,1.72))