
import { Component, ViewEncapsulation } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DxReportViewerModule } from 'devexpress-reporting-angular';
import { FormsModule } from '@angular/forms';
import { environment } from '../../environments/environment';

@Component({
  selector: 'app-dynamicjson',
  encapsulation: ViewEncapsulation.None,
  standalone: true,
  imports: [
    CommonModule,
    FormsModule,
    DxReportViewerModule
  ],
  templateUrl: './dynamicjson.component.html',
  styleUrls: [
    "../../../node_modules/devextreme/dist/css/dx.light.css",
    "../../../node_modules/@devexpress/analytics-core/dist/css/dx-analytics.common.css",
    "../../../node_modules/@devexpress/analytics-core/dist/css/dx-analytics.light.css",
    "../../../node_modules/devexpress-reporting/dist/css/dx-webdocumentviewer.css"
  ]
})
export class DynamicjsonComponent {
  title = 'DXReportViewerSample';
  fileTypes: string[] = ["Employee - 6 MB", "Employee - 13 MB", "Employee - 19 MB"];
  selectedFileType: string = "";
  reportUrl: string = 'DynamicJsonReport';
  hostUrl: string = environment.baseUrl;
  invokeAction: string = environment.adminRoutePath;

  getFileTypeValue(fileType: string): number {
    const index = this.fileTypes.indexOf(fileType);
    return index !== -1 ? index + 1 : -1; // Returns -1 if fileType is not found
  }

  submitParameter() {
    this.reportUrl = `DynamicJsonReport?fileTypeParam=${this.getFileTypeValue(this.selectedFileType)}`;
  }
}
