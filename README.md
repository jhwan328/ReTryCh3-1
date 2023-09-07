# ReTryCh3-1
1. 코드가 엉켜서 다시 만들었기 때문에 Retry가 붙었습니다.
2. Scene은 총 3개로 이름을 입력하는 OpenScene과 캐릭터를 고르는 ClassScene, 게임이 진행되는 MainScene이 있습니다.

## OpenScene
1. InputField에 알파벳을 입력하고 Join을 누르면 입력한 문자열은 DataManager에 저장된 체로 ClassScene으로 넘어갑니다.

### ClassScne
1. 여기서 캐릭터로 knight와 elf 둘 중 하나를 선택할 수 있습니다.
2. 선택한 내용은 dataManager에 저장되고 다음 MainScene으로 넘어갑니다.

#### MainScene
1. 처음 Scene이 시작됐을 때 spawnManager에서 dataManager의 정보를 바탕으로 플레이어를 생성합니다.
2. 플레이어는 WASD로 이동할 수 있으며 카메라의 좌표는 '플레이어의 좌표 + 지정된 높이'이기에 플레이어를 따라 움직이게 됩니다.
3. 하단의 Name과 Class를 누르면 Name을 문자열을 입력할 수 있는 공간이, Class는 2개의 Sprite가 나옵니다.
4. Name을 입력하고 바로 밑의 붉은 버튼을 누르면 Name이 바뀝니다.
5. Class를 누르고 나타난 2개의 Sprite 중 하나를 누르면 캐릭터가 바뀝니다. 그에 따라 애니매이션 컨트롤러도 바뀝니다. 우측 상단의 X표 버튼을 누르면 Sprite는 다시 사라집니다. 
