import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TileComponent } from './tile/tile.component';
import { NgbModule} from '@ng-bootstrap/ng-bootstrap';
import { GridComponent } from './grid/grid.component';
import { LabelComponent } from './label/label.component';
import { InputTextComponent } from './input-text/input-text.component';
import { InputNumberComponent } from './input-number/input-number.component';
import { DatePickerComponent } from './date-picker/date-picker.component';
import { DropdownComponent } from './dropdown/dropdown.component';
import { FormsModule } from '@angular/forms';
import { InputPasswordComponent } from './input-password/input-password.component';
import { CheckboxComponent } from './checkbox/checkbox.component';
import { InputButtonComponent } from './input-button/input-button.component';
import { InputComponent } from './input/input.component';

const moduleComponents = [
  TileComponent,
  GridComponent,
  LabelComponent,
  InputTextComponent,
  InputNumberComponent,
  DatePickerComponent,
  DropdownComponent,
  InputPasswordComponent,
  CheckboxComponent,
];
@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    // FormArray,
    // FormGroup,
    // FormBuilder,
    // FormControl,
    NgbModule,
  ],
  declarations: [moduleComponents, InputButtonComponent, InputComponent],
  exports: [moduleComponents]
})
export class UiComponentsModule { }
