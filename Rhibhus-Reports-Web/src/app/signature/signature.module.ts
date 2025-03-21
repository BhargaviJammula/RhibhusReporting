import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SignatureComponent } from './signature.component';
import { SignaturePadModule } from 'ngx-signaturepad'; // Import the correct module

@NgModule({
  declarations: [SignatureComponent],
  imports: [CommonModule, SignaturePadModule], // Use SignaturePadModule
  exports: [SignatureComponent]
})
export class SignatureModule {}
