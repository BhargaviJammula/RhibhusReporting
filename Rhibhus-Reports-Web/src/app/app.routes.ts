import { Routes } from '@angular/router';

import { AdminComponent } from './admin/admin.component';
import { UserComponent } from './user/user.component';
import { TabpanelComponent } from './tabpanel/tabpanel.component'
import { SignatureComponent } from './signature/signature.component';

export const routes: Routes = [
    { path: '', redirectTo: '/admin', pathMatch: 'full' },
    { path: 'admin', component: AdminComponent },
    { path: 'tabpanel', component: TabpanelComponent },
    { path: 'user', component: UserComponent },
    { path: 'signature', component: SignatureComponent },
  ];
