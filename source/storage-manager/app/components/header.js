import Component from '@ember/component';
import { action } from "@ember/object";
import { inject as service } from '@ember/service';

export default class HeaderComponent extends Component {
    @service router;

    @action
    clickLogout() {
        this.get('router').transitionTo('login');
    }
}
