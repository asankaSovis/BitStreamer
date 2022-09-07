# 📩 BitStreamer
 
![Poster](https://user-images.githubusercontent.com/46389631/188691993-8064bd70-b6fb-4ec8-b642-3728f5970e13.png)

---

BitStreamer is a data streaming software developed for communication engineers to send a bit stream from one COM port and check how many bits can be recieved back from another COM port. Here, the bitstream from the first COM port can be sent through a communication medium to check the efficiency of communication medium. 

> ![BitStreamer Application](https://user-images.githubusercontent.com/46389631/188698470-379a8334-5998-4bc5-a378-e14e2e07d0ac.png)
> Main window of the application

## Features

- Send and recieve bits from one port to the other
- Automatic generation of random bitstreams
- Support for multiple tests
- Bidirectional mode

> ![image](https://user-images.githubusercontent.com/46389631/188799569-0fccea86-e9af-410e-a50d-51027b8333a4.png)
> Bidirectional mode

## Usage

1. Open the application.
2. Go to `Options > Directional Mode` and choose `Bidirectional Mode` if needed.
3. Under `Transmitter`, choose the transmitting COM port and baud rate and click `Connect`.
4. Under `Reciever`, choose the recieving COM port and baud rate and click `Connect`.
5. If needed, go to `Bitstream > Generate Bitstream` or change the state of any required bits under `Transmitter`.
6. Click on send and wait for the bits to be recieved by the `Reciever`.

> ![Send Bitstream](https://user-images.githubusercontent.com/46389631/188798042-3a5aa76c-68f5-4247-a495-1267a11243cf.png)
> Sending a bitstream

7. If required, set the amount of tests needed to be run and click on `Run Test`.

> ![Test](https://user-images.githubusercontent.com/46389631/188798393-e7b62b39-5cf8-4e23-b63d-ce76b6f888e1.png)
> Running a test

`© 2022 Asanka Sovis`
