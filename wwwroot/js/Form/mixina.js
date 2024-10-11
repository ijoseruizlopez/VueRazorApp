const _formMixinA = {
    data() {
        return {

            formData: {
                name: '',
                email: '',
                country: '',
                agree: false
            },
            countries: [],
            submitting: false,
            errorMessage: '',
            successMessage: ''
        };
    },
    methods: {
        fetchData() {

            axios.get('/Map/countries')
                .then(response => {
                    this.countries = response.data;
                })
                .catch(error => {
                    this.errorMessage = 'Failed to load countries.';
                });
        },
        submitForm() {

            this.submitting = true;
            this.errorMessage = '';
            this.successMessage = '';

            if (!this.formData.name || !this.formData.email || !this.formData.country || !this.formData.agree) {

                this.errorMessage = 'Por favor, completa todos los campos y acepta los términos.';
                this.submitting = false;

            }
            else {
                this.successMessage = '¡Formulario enviado con éxito!';
                this.clearForm();
            }
        },
        clearForm() {

            this.formData = {
                name: '',
                email: '',
                country: '',
                agree: false
            };

            this.errorMessage = '';
            this.successMessage = '';
        }
    },
    mounted() {
        this.fetchData();
    }
};