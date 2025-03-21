import { Component, ViewChild, ElementRef, AfterViewInit, signal, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import SignaturePad from 'signature_pad';

@Component({
  selector: 'app-signature',
  templateUrl: './signature.component.html',
  styleUrls: ['./signature.component.css']
})
export class SignatureComponent implements AfterViewInit {
  @ViewChild('signaturePad') signaturePadElement!: ElementRef<HTMLCanvasElement>;
  private signaturePad!: SignaturePad;
  private http = inject(HttpClient); // ✅ Using `inject` instead of constructor

  signaturePadOptions = {
    minWidth: 2,
    canvasWidth: 400,
    canvasHeight: 200
  };

  ngAfterViewInit() {
    if (this.signaturePadElement) {
      this.signaturePad = new SignaturePad(this.signaturePadElement.nativeElement, this.signaturePadOptions);
    }
  }

  clearSignature() {
    this.signaturePad.clear();
  }

  saveSignature() {
    if (this.signaturePad.isEmpty()) {
      alert('Please provide a signature first.');
      return;
    }

    const dataURL = this.signaturePad.toDataURL(); // Get signature as base64

    this.http.post('http://localhost:5000/sign', { signature: dataURL }).subscribe(
      (response) => {
        console.log('Signature saved:', response);
        alert('Signature saved successfully!');
      },
      (error) => {
        console.error('Error saving signature:', error);
        alert('Failed to save signature.');
      }
    );
  }
}
