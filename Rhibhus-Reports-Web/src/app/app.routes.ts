import { Routes } from '@angular/router';

import { AdminComponent } from './admin/admin.component';
import { UserComponent } from './user/user.component';
import { TabpanelComponent } from './tabpanel/tabpanel.component'
import { SignatureComponent } from './signature/signature.component';
import { TocComponent } from './toc/toc.component';
import { JsonComponent } from './json/json.component';
import { EmployeedetailsComponent  } from './employeedetails/employeedetails.component';
import { DynamicjsonComponent  } from './dynamicjson/dynamicjson.component';

export const routes: Routes = [
    { path: '', redirectTo: '/admin', pathMatch: 'full' },
    { path: 'admin', component: AdminComponent },
    { path: 'tabpanel', component: TabpanelComponent },
    { path: 'user', component: UserComponent },
    { path: 'signature', component: SignatureComponent },
    { path: 'toc', component: TocComponent  },
    { path: 'json', component: JsonComponent  },
    { path: 'employeedetails', component: EmployeedetailsComponent },
    { path: 'dynamicjson', component: DynamicjsonComponent },
  ];
