FROM public.ecr.aws/lambda/dotnet:5.0
#You can alternately also pull these images from DockerHub amazon/aws-lambda-dotnet:5.0

# Copy function code
COPY net5-lambda-template/bin/Debug/net5.0 ${LAMBDA_TASK_ROOT}

# Set the CMD to your handler (could also be done as a parameter override outside of the Dockerfile)
CMD [ "net5-lambda-template::net5_lambda_template.LambdaFunction::Handler" ]