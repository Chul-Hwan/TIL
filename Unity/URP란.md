# URP
[영상링크](https://www.youtube.com/watch?v=wNFjsi6MjAQ)

## Built in Render Pipeline의 한계
- 각 분야에 맞게 최적화가 불가능
- 렌더 파이프라인 영역을 마음대로 수정할 수 없음

## SRP
- Scriptable Render Pipeline
- C#으로 렌더 파이프라인을 직접 작성하는 것.
- 시간 능력 돈이 필요함

## URP HDRP
- SRP의 템플릿으로 제공
- Universal Render Pipeline

## URP 장점
- 쉐이더 그래프 제공
- 최신기능 탑재
- 지속적인 업데이트 ( Built-in은 지원종료 ) 

## URP/Lit으로 바로 변경 가능한 이유
- Standard 셰이더에 있는 부분이라면 Lit 셰이더로 변경하는데에는 큰 무리가 없다.
- 커스텀으로 선언한 부분은 사용할 수 없음

## URP의 장점
- 다수의 실시간 광원
- SRP Batcher
- 포스트 프로세싱
- 업스케일 샘플링

### 다수의 실시간 광원
조명이 여러개 있으면 기존에는 다수의 광원이면 다수의 드로우콜이 발생

UPR는 다수의 광원이라도 한 번의 드로우콜이 발생

#### Draw Call
- CPU가 GPU에게 보내는 그려달라는 명령들
- 명령횟수가 적을수록 성능에 좋음

### SRP Batcher
- 기존 Batcher는 같은 머테리얼을 공유하는 메시를 한 번에 그리는 것.
- 그래서 2D 게임은 텍스처를 하나에 묶음 (아틀라스)
- SRP Batcher는 쉐이더 단위로 묶음

## Post processing
- 렌더링이 끝낸 화면에 후처리하는 것
- Bloom에서 상당히 유의미한 성능향상이 있음.
- Bokeh DoF의 경우 어쩔 수 없이 무거운 효과라 Gaussian DoF 효과 추가

## Upscale Sampling
- 3D 씬을 RenderTexure에 저해상도로 렌더링
- 화면 해상도에 맞게 RenderTexure를 늘려서 출력
- UI는 기존해상도로 출력하여 눈치를 못채게 함.
- 퀄리티탭에서 RenderScale 값을 조정하면 됨.

## 모바일 개발 시
- OPENGL ES 3.2 텍스처 압축포맷 중 ASTC 포맷을 사용할 수 있음.
- ASTC 포맷을 사용하면 iOS, Android에서 ASTC포맷으로 통일가능
- OpenGL ES 3.2 75.92%, 3.1은 82.55%
- 구글플레이에서 게임을 다운로드한 사용자 기준, OpenGL ES 3.2 90%, 3.1 2%
- OpenGL ES 3.0으로 사용 시, SRP Batcher로 인한 Draw Call 감소를 얻을 수 없고, ASTC를 통한 텍스처 압축효과를 볼 수 없음




