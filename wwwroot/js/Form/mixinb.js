const _formMixinB = {
    data() {
        return {
            formDataSecond: {
                name: '',
                email: '',
                age: '',
                agree: false
            },
            submittingSecondForm: false,
            errorMessageSecondForm: '',
            successMessageSecondForm: ''
        };
    },
    methods: {
        submitSecondForm() {

            this.submittingSecondForm = true;
            this.errorMessageSecondForm = '';
            this.successMessageSecondForm = '';

            // Validamos los campos
            if (!this.formDataSecond.name || !this.formDataSecond.email || !this.formDataSecond.age || !this.formDataSecond.agree) {

                this.errorMessageSecondForm = 'Por favor, completa todos los campos y acepta los términos.';
                this.submittingSecondForm = false;

                return;
            } 
            else {

                this.successMessageSecondForm = '¡Formulario 2 enviado con éxito!';
                this.clearSecondForm();
            }
        },
        clearSecondForm() {

            this.formDataSecond = {
                name: '',
                email: '',
                age: '',
                agree: false
            };

            this.errorMessageSecondForm = '';
            this.successMessageSecondForm = '';
        }
    }
};